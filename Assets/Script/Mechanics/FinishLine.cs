using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour 
{
    // Use this for initialization
    void Start () 
    {
    
    }

    // Update is called once per frame
    void Update () 
    {
    
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.name == "Player") 
        {
            SceneManager.LoadScene("Won");
        }
    }
}
