using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbage : Adagio {

    public override void interact() {
        if(!isCaught) {
            Lives.LoseLife();
            Destroy(this.gameObject);
        }
    }
}