using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Allegro : MoveParent {
    public override float getVelocity(){
        return ( (float) ProbabilityDensityFunctions.VelocityAllegro() );
    }
    public override abstract void interact();
}
