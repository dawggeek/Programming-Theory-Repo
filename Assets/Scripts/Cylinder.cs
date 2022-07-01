using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    private static int cylinderCounter = 0;

    void Awake()
    {
        cylinderCounter++;
        SetShapeData("Cylinder", Color.red);
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        textLabel.text = "Clicked a " + shapeName + " number " + cylinderCounter;
    }
}
