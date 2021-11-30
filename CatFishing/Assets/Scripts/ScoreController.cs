using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
    public Text counter;
    private static int counterValue;

    // Start is called before the first frame update
    void Start() {
        counterValue = 0;
    }

    // Update is called once per frame
    void Update() {
        counter.text = counterValue.ToString();
    }

    public static void Increment(int score) {
        counterValue += score;
    }
}
