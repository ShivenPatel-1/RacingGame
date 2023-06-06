using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Standard : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1S");
    }
}