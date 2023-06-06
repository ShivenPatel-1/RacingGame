using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            PlayerController.numberOfCoins++;
            PlayerPrefs.SetInt("NumberOfCoins", PlayerController.numberOfCoins);
            Destroy(gameObject);
        }
    }
}