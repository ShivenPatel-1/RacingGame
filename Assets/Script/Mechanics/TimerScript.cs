using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //imports timer

public class TimerScript : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;
    public float startTime;
    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;
    // Start is called before the first frame update
    void Start()
    {
        startTime = currentTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime; //if countdown is true, the first condition (-=) runs and then (+=) runs if it's false
        
        if(hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit))){
            currentTime = timerLimit;
            SetTimerText();
            enabled = false;
        }
        
        SetTimerText();

        if(currentTime == timerLimit){
            SceneManager.LoadScene("Lost");
        }
    }

    private void SetTimerText(){
        timerText.text = currentTime.ToString("0");
    }

    //-----------------------------------------------------------------------------//

    public void timeBoost(){
        currentTime += 3f;
    }

}