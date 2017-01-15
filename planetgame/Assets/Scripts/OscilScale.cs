using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscilScale : MonoBehaviour {
    public bool xOscil;
    public bool yOscil;
    public bool zOscil;
    public float oscilIncrement;
    public float oscilMaxValue;
    private float oscilCurrentVal;
    private bool isIncreasing;
    private float xVal;
    private float yVal;
    private float zVal;
    // Use this for initialization
    void Start () {
        oscilCurrentVal = 0;
        xVal = 1;
        yVal = 1;
        zVal = 1;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (isIncreasing)
        {
            oscilCurrentVal += oscilIncrement;
        }
        else
        {
            oscilCurrentVal -= oscilIncrement;
        }
        if (oscilCurrentVal > oscilMaxValue)
        {
            isIncreasing = false;
        }
        if (oscilCurrentVal < -oscilMaxValue)
        {
            isIncreasing = true;
        }
        if (xOscil)
        {
            xVal = oscilCurrentVal;
        }
        else
        {
            xVal = transform.localScale.x;
        }
        if (yOscil)
        {
            yVal = oscilCurrentVal;
        }
        else
        {
            yVal = transform.localScale.y;
        }
        if (zOscil)
        {
            zVal = oscilCurrentVal;
        }
        else
        {
            zVal = transform.localScale.z;
        }
        transform.localScale = new Vector3(xVal, yVal, zVal);
	}
}
