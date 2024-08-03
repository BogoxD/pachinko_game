using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
        }

    }
    public void SetRigidBodyKinematic()
    {
        rigidbody2D.bodyType = RigidbodyType2D.Kinematic;
    }
}
