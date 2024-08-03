using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTrigger : MonoBehaviour
{
    [SerializeField] PlayerController player;
    [SerializeField] Spawn ballSpawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (gameObject.CompareTag("Move"))
                player.MoveForward();
            if (gameObject.CompareTag("Shoot"))
                player.Shoot();

            ballSpawn.ResetBallPoisiton();
            ballSpawn.GetComponentInChildren<Ball>().SetRigidBodyKinematic();
        }
    }
}
