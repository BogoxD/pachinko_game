using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 2f;
    public bool loopPosition;
    public float loopTime = 1f;
    public float offset = 1f;

    [Header("Destroy")]
    public float destroyTime = 10f;
    public bool destroyObjectInTime;

    private void Start()
    {
        if (loopPosition)
            InvokeRepeating(nameof(LoopObj), 0f, loopTime + offset);
    }
    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (destroyObjectInTime)
            Destroy(gameObject, destroyTime);
    }
    private void LoopObj()
    {
        speed *= -1;
    }
}
