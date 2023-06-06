using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotholeCollision : MonoBehaviour
{
    public PlayerController playerController; // Reference to the player's controller script

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Disable the player's controller script for 3 seconds
            playerController.enabled = false;
            StartCoroutine(EnablePlayerControllerAfterDelay(2f));
        }
    }

    private IEnumerator EnablePlayerControllerAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        playerController.enabled = true;
    }
}