using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GammaFunction : MonoBehaviour {
   public static double LnGamma(double alpha) {
        // Pike MC & Hill ID (1966) Algorithm 291: Logarithm of the gamma function.
        // Communications of the Association for Computing Machinery, 9:684

        double x = alpha, f = 0.0, z;

        if (x < 7) {
            f = 1;
            z = x - 1;
            while (++z < 7) {
                f *= z;
            }
            x = z;
            f = -Math.Log(f);
        }
        z = 1 / (x * x);

        return f
                + (x - 0.5)
                * Math.Log(x)
                - x
                + 0.918938533204673
                + (((-0.000595238095238 * z + 0.000793650793651) * z - 0.002777777777778)
                * z + 0.083333333333333) / x;
    }

    public static double IncompleteGammaQ(double a, double x) {
        return 1.0 - IncompleteGamma(x, a, LnGamma(a));
    }


    public static double IncompleteGammaP(double a, double x) {
        return IncompleteGamma(x, a, LnGamma(a));
    }


    public static double IncompleteGammaP(double a, double x, double lnGammaA) {
        return IncompleteGamma(x, a, lnGammaA);
    }

    private static double IncompleteGamma(double x, double alpha,
                                          double ln_gamma_alpha) {
        // (1) series expansion if (alpha>x || x<=1)
        // (2) continued fraction otherwise
        // RATNEST FORTRAN by
        // Bhattacharjee GP (1970) The incomplete gamma integral. Applied
        // Statistics,
        // 19: 285-287 (AS32)

        double accurate = 1e-8, overflow = 1e30;
        double factor, gin, rn, a, b, an, dif, term;
        double pn0, pn1, pn2, pn3, pn4, pn5;

        if (x == 0.0) {
            return 0.0;
        }
        if (x < 0.0 || alpha <= 0.0) {
            throw new ArgumentException("Arguments out of bounds");
        }

        factor = Math.Exp(alpha * Math.Log(x) - x - ln_gamma_alpha);

        if (x > 1 && x >= alpha) {
            // continued fraction
            a = 1 - alpha;
            b = a + x + 1;
            term = 0;
            pn0 = 1;
            pn1 = x;
            pn2 = x + 1;
            pn3 = x * b;
            gin = pn2 / pn3;

            do {
                a++;
                b += 2;
                term++;
                an = a * term;
                pn4 = b * pn2 - an * pn0;
                pn5 = b * pn3 - an * pn1;

                if (pn5 != 0) {
                    rn = pn4 / pn5;
                    dif = Math.Abs(gin - rn);
                    if (dif <= accurate) {
                        if (dif <= accurate * rn) {
                            break;
                        }
                    }

                    gin = rn;
                }
                pn0 = pn2;
                pn1 = pn3;
                pn2 = pn4;
                pn3 = pn5;
                if (Math.Abs(pn4) >= overflow) {
                    pn0 /= overflow;
                    pn1 /= overflow;
                    pn2 /= overflow;
                    pn3 /= overflow;
                }
            } while (true);
            gin = 1 - factor * gin;
        } else {
            // series expansion
            gin = 1;
            term = 1;
            rn = alpha;
            do {
                rn++;
                term *= x / rn;
                gin += term;
            } while (term > accurate);
            gin *= factor / alpha;
        }
        return gin;
    }


}
