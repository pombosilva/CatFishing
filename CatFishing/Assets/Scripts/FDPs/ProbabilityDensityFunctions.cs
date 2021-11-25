using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProbabilityDensityFunctions : MonoBehaviour {
    public int TypeOfObjectL1(){
        System.Random r = new System.Random();
        double u = r.NextDouble();
        if (u < 0.5)
            return 0;
        else if (u < 0.7)
            return 1;
        else if (u < 0.825)
            return 2;
        else if (u < 0.95)
            return 3;
        else
            return 4;
    }
    
    public int TypeOfObjectL2(){
        System.Random r = new System.Random();
        double u = r.NextDouble();
            if (u < 0.2)
                return 0;
            else if (u < 0.35)
                return 1;
            else if (u < 0.525)
                return 2;
            else if (u < 0.7)
                return 3;
            else if (u < 0.85)
                return 4;
            else
                return 5;
    }

    public int Side() {
        System.Random r = new System.Random();
        double u = r.NextDouble();
        if (u < 0.5)
            return -1;
        else
            return 1;
    }

    public double TimeBetweenObjectsL1(){
        System.Random r = new System.Random();
        double u = r.NextDouble();
        return -2 * Math.Log(1-u*((Math.Exp(1)-1)/Math.Exp(1))) + 2;   
    }

    public double TimeBetweenObjectsL2(){
        System.Random r = new System.Random();
        double u = r.NextDouble();
        return -1 * Math.Log(1-u*((Math.Exp(2)-1)/Math.Exp(2))) + 1;
    }

    public double VelocityAdagio(){
        System.Random r = new System.Random();
        double u = r.NextDouble();
        return 0.5 * Math.Pow(-1*Math.Log(1-u*0.88276),1/1.1);
    }

    public double VelocityAllegro(){
        System.Random r = new System.Random();
        double u = r.NextDouble();
        return Math.Pow((-1*Math.Log(1-u*((Math.E - 1)/Math.E))),1/3f);
    }

    public double PositionInHeight(){
        System.Random r = new System.Random();
        double u = r.NextDouble();
        return ErrorFunction.InverseErf( u*( ErrorFunction.Erf(5/(4*Math.Sqrt(2)))-ErrorFunction.Erf(-5/(4*Math.Sqrt(2)))) + ErrorFunction.Erf(-5/(4*Math.Sqrt(2)))) * 4*Math.Sqrt(2) + 5;
    }

}
