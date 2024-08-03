using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    public float speed = 2f;
    public float destroyTime = 10f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        Destroy(gameObject, destroyTime);
    }
}
