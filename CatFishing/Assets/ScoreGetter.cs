using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGetter : MonoBehaviour {

    // Start is called before the first frame update
    void Start()
    {
        Text text = this.GetComponent<Text>();
        text.text = ScoreController.GetScore().ToString();
    }
}
