using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbage : Adagio {

    public override void interact() {
        if(!isCaught) {
            Lifes.LoseLife();
            Destroy(this.gameObject);
        }
    }
}