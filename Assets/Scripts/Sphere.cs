using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    private static int sphereCounter = 0;

    void Awake()
    {
        sphereCounter++;
        SetShapeData("Sphere", Color.green);
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        textLabel.text = "Clicked a " + shapeName + " number " + sphereCounter;
    }
}
