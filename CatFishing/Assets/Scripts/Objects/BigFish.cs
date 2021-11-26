using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFish : Adagio {
    public override void interact() {
        if(!isCaught) {
            //isCaught = true;
            Destroy(this.gameObject);
        }
    }
}
