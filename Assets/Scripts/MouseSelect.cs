
using UnityEngine;
using System.Collections;

public class MouseSelect : MonoBehaviour
{

    public Shader selectedShader;
    //public Color outterColor;


    //private Color myColor;
    private Shader myShader;
    private bool Selected = false;

    // Use this for initialization
    void Start()
    {

        //myColor = GetComponent<Renderer>().material.color;
        myShader = GetComponent<Renderer>().material.shader;

        //selectedShader = Shader.Find("Custom/sample");
        if (!selectedShader)
        {
            enabled = false;
            return;
        }
    }

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.shader = selectedShader;

        //GetComponent<Renderer>().material.SetColor("_RimColor", outterColor);

        //GetComponent<Renderer>().material.SetColor("_MainColor", myColor);
    }

    void OnMouseExit()
    {
        //GetComponent<Renderer>().material.color = myColor;

        GetComponent<Renderer>().material.shader = myShader;
    }
}
