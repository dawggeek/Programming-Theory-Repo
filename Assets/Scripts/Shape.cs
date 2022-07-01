using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    protected string shapeName { get; private set; }
    protected Color shapeColor { get; private set; }

    protected TextMeshProUGUI textLabel;

    // Start is called before the first frame update
    void Start()
    {
        textLabel = GameObject.Find("DisplayText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ABSTRACTION
    protected void OnMouseDown()
    {
        DisplayText();
        Destroy(gameObject);
    }

    // ABSTRACTION
    protected void SetShapeData(string name, Color color)
    {
        shapeName = name;
        shapeColor = color;

        GetComponent<Renderer>().material.SetColor("_Color", color);
    }

    public abstract void DisplayText();
}
