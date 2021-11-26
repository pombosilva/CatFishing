using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Adagio : MoveParent {
    public override float getVelocity() {
        return ( (float) ProbabilityDensityFunctions.VelocityAdagio() );
    }

    public override abstract void interact();
}
