using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 2f;
    public int bulletDamage = 100;
    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb2D.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
    }
}
