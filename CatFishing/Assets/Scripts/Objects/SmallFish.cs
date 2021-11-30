using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallFish : Adagio {
    private int score = 1;
    public override void interact() {
        if(!isCaught) {
            //isCaught = true;
            ScoreController.Increment(score);
            Destroy(this.gameObject);
        }
    }
}
