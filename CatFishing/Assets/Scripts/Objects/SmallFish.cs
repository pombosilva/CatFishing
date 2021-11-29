using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallFish : Adagio {
    public override void interact() {
        if(!isCaught) {
            //isCaught = true;
            Counter.counterValue += 1;
            Destroy(this.gameObject);
        }
    }
}
