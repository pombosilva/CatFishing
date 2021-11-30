using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octopus : Allegro
{
    public GameObject ink;
    public override void interact() {
        if(!isCaught) {
            //isCaught = true;
            Instantiate(ink, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
