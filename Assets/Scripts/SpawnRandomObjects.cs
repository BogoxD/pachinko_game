using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomObjects : MonoBehaviour
{
    public GameObject[] objects;
    public float spawnDelay;

    public void Start()
    {
        InvokeRepeating(nameof(SpawnClouds), 0.1f, spawnDelay);
    }
    private void SpawnClouds()
    {
        Instantiate(objects[Random.Range(0, objects.Length)], transform.position, Quaternion.identity, transform);

    }
}
