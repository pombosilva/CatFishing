using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public static TimerController instance;

    public Text timeCounter;

    private TimeSpan timePlaying;
    private bool timerGoing;

    private float elapsedTime;

    private void Awake(){
    
        instance = this;
        
    }

    // Start is called before the first frame update
    void Start()
    { 
        timeCounter.text = "02:00";
        timerGoing = true;
        elapsedTime = 120f;
    }

    // Update is called once per frame
    void Update()
    {
        if(EndTimer()){
            print(Time.deltaTime);
            elapsedTime -= Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = timePlaying.ToString("mm':'ss");
            timeCounter.text = timePlayingStr;

            print(timePlayingStr);
        }
    }

    public bool EndTimer(){
        if(elapsedTime < 0f){
        timerGoing = false;
        } 
        print(timerGoing);
        return timerGoing;
    }

    public int getSeconds(){
        return (int)elapsedTime;
    }

}
