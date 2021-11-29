using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {
    public static int counterValue = 0;
    Text counter;

    // Start is called before the first frame update
    void Start() {
        counter = GetComponent<Text> ();
        counterValue = 0;
    }

    // Update is called once per frame
    void Update() {
        counter.text = counterValue.ToString() ;
        
    }
}
