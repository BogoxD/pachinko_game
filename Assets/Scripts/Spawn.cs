using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ball;
    public int spawnRange;

    void Start()
    {
        ResetBallPoisiton();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            ResetBallPoisiton();
            GetComponentInChildren<Ball>().SetRigidBodyKinematic();
        }
    }
    public void ResetBallPoisiton()
    {
        ball.transform.position = new Vector2(transform.position.x + Random.Range(-spawnRange, spawnRange), transform.position.y);
        ball.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody2D>().angularVelocity = 0f;
        ball.transform.eulerAngles = Vector3.zero;
    }
}
