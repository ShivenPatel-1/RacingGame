using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float carSpeedBoost = 5f;
    public float turnSpeedBoost = 5f;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.carSpeed += carSpeedBoost;
            playerController.turnSpeed += turnSpeedBoost;
            Destroy(gameObject);
        }
    }
}