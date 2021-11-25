using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Allegro : MoveParent {
    public override float getVelocity(){
        return ( (float) ProbabilityDensityFunctions.VelocityAllegro() );
    }
}
