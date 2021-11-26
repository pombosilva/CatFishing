using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octopus : Allegro
{
    public override void interact() {
        if(!isCaught) {
            //isCaught = true;
            Destroy(this.gameObject);
        }
    }
}
