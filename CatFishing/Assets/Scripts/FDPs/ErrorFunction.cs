using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ErrorFunction : MonoBehaviour {
   public static double Erf(double x) {
        if (x > 0.0) {
            return GammaFunction.IncompleteGammaP(0.5, x * x);
        } else if (x < 0.0) {
            return -GammaFunction.IncompleteGammaP(0.5, x * x);
        } else {
            return 0.0;
        }
    }

    public static double Erfc(double x) {
        return 1.0 - Erf(x);
    }

    public static double InverseErf(double z) {
        return PointNormal(0.5 * z + 0.5) / Math.Sqrt(2.0);
    }

     private static double PointNormal(double prob) {
        // Odeh RE & Evans JO (1974) The percentage points of the normal
        // distribution.
        // Applied Statistics 22: 96-97 (AS70)

        // Newer methods:
        // Wichura MJ (1988) Algorithm AS 241: the percentage points of the
        // normal distribution. 37: 477-484.
        // Beasley JD & Springer SG (1977). Algorithm AS 111: the percentage
        // points of the normal distribution. 26: 118-121.

        double a0 = -0.322232431088, a1 = -1, a2 = -0.342242088547, a3 = -0.0204231210245;
        double a4 = -0.453642210148e-4, b0 = 0.0993484626060, b1 = 0.588581570495;
        double b2 = 0.531103462366, b3 = 0.103537752850, b4 = 0.0038560700634;
        double y, z = 0, p = prob, p1;

        p1 = (p < 0.5 ? p : 1 - p);
        if (p1 < 1e-20) {
            new ArgumentException("Argument prob out of range");
        }

        y = Math.Sqrt(Math.Log(1 / (p1 * p1)));
        z = y + ((((y * a4 + a3) * y + a2) * y + a1) * y + a0)
                / ((((y * b4 + b3) * y + b2) * y + b1) * y + b0);
        return (p < 0.5 ? -z : z);
    }
}
