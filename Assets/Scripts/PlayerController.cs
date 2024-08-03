using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public TextMeshProUGUI gameOverText;

    private Rigidbody2D rb2D;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    public void MoveForward()
    {
        rb2D.AddForce(transform.right * moveSpeed, ForceMode2D.Impulse);
    }
    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.transform.position, Quaternion.identity, transform);
        bullet.GetComponent<Rigidbody2D>().gravityScale = 0f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameOverText.enabled = true;

            StartCoroutine(ResetScene());
        }
    }
    IEnumerator ResetScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }
}
