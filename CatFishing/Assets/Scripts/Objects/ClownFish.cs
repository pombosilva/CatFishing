using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownFish : Allegro {
    private int score = 5;
    public override void interact() {
        if(!isCaught) {
            //isCaught = true;
            ScoreController.Increment(score);
            Destroy(this.gameObject);
        }
    }
}
