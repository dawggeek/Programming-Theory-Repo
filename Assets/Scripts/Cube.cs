using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    private static int cubeCounter = 0;

    void Awake()
    {
        cubeCounter++;
        SetShapeData("Cube", Color.blue);
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        textLabel.text = "Clicked a " + shapeName + " number " + cubeCounter;
    }
}
