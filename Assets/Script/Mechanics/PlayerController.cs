using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float carSpeed = 50f;
    public float turnSpeed = 175f;
    
    public static int numberOfCoins = 0;
    public TextMeshProUGUI coinsText;

    public int maxHealth = 5;
    public int healthRestore = 2;
    public int currentHealth;
    public HealthBar healthBar;

    public void Start()
    {
        numberOfCoins = 0;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void Awake()
    {
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * carSpeed * Time.deltaTime);
        transform.Rotate(Vector3.back * horizontalInput * turnSpeed * Time.deltaTime);

        coinsText.text = numberOfCoins.ToString() ;

        if(currentHealth == 0)
        {
            SceneManager.LoadScene("Lost");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            TakeDamage(1);
        }

        if(collision.CompareTag("SpeedBoost"))
        {
            currentHealth = currentHealth + healthRestore;
            healthBar.SetHealth(currentHealth);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}