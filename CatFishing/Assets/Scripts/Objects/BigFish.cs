using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFish : Adagio {
    private int score = 2;
    public override void interact() {
        if(!isCaught) {
            //isCaught = true;
            ScoreController.Increment(score);
            Destroy(this.gameObject);
        }
    }
}
