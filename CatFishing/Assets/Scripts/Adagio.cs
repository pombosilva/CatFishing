using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adagio : MoveParent {
    public override float getVelocity(){
        return ( (float) ProbabilityDensityFunctions.VelocityAdagio() );
    }
}
