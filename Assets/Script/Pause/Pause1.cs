using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause1 : MonoBehaviour
{
    public void Pause()
    {
        SceneManager.LoadScene("Pause1");
    }
}