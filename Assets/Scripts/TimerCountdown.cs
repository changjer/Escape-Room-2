//Countdown timer with some code refernced from https://www.youtube.com/watch?v=Qhm_t46kuM4
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class TimerCountdown : MonoBehaviour
{
    
    public GameObject displayTime;
    public int minutes;
    private int secondsLeft = 60;
    public bool countingDown;
    int time;

    void Start()
    {
        if(minutes < 10)
        {
            displayTime.GetComponent<Text>().text = "0" + minutes + ":00";
        }
        else
        {
            displayTime.GetComponent<Text>().text = minutes + ":00";
        }
        minutes--;
        
    }

    void Update()
    {
        if (countingDown == true && minutes >=0)
        {
            //Debug.Log(secondsLeft);
            StartCoroutine(SubtractTime());
        }

    }
    IEnumerator SubtractTime()
    {
        countingDown = false;
        yield return new WaitForSeconds(1);
        secondsLeft--;
        if (minutes > 10 && secondsLeft < 10)
        {
            displayTime.GetComponent<Text>().text = minutes + ":0" + secondsLeft;
        }
        else if (minutes > 10 && secondsLeft > 10)
        {
            displayTime.GetComponent<Text>().text = minutes + ":" + secondsLeft;
        }
        else if (minutes < 10 && secondsLeft < 10)
        {
            displayTime.GetComponent<Text>().text = "0" + minutes + ":0" + secondsLeft;
        }
        else
        {
            displayTime.GetComponent<Text>().text = "0" + minutes + ":" + secondsLeft;
        }

        if(secondsLeft == 0 && minutes >= 0)
        {
            minutes--;
            secondsLeft = 60;
        }
        countingDown = true;
    }
}
