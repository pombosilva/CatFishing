using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {
    public Text timeCounter;
    private TimeSpan timePlaying;
    private float remainingTime;

    // Start is called before the first frame update
    void Start() { 
        timeCounter.text = "02:00";
        remainingTime = 120f;
    }

    // Update is called once per frame
    void Update() {
        if(remainingTime >= 0f) {
            remainingTime -= Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(remainingTime);
            timeCounter.text = timePlaying.ToString("mm':'ss");
        }
    }

    public int getLevel() {
        return ( remainingTime > 60f ? 1 : 2 );
    }

}
