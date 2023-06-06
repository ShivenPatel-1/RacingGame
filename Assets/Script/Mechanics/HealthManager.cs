using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    /*
    public int health;
    public int maxHealth = 5;
    public int healthRestore = 2;
    public HealthBar healthBar;

    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        healthBar.SetHealth(health);
        if (health <= 0)
        {
            SceneManager.LoadScene("Lost");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "SpeedBoost")
        {
            health = health + healthRestore;
            healthBar.SetHealth(health);
        }

        if (collision.CompareTag("Obstacle"))
        {
            TakeDamage(1);
        }
    }
    */
}
