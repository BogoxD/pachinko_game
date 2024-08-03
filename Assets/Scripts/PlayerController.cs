using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform firePoint;
    public GameObject bulletPrefab;

    private Rigidbody2D rb2D;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //DEBUG
        if (Input.GetKeyDown(KeyCode.D))
            MoveForward();
        if (Input.GetKeyDown(KeyCode.S))
            Shoot();

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
}
