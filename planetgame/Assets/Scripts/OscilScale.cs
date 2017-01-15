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
        oscilValue = new Vector3(0,0,0);
        oscilCurrentVal = 0;
        xVal = 0;
        yVal = 0;
        zVal = 0;
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
        if (yOscil)
        {
            yVal = oscilCurrentVal;
        }
        if (zOscil)
        {
            zVal = oscilCurrentVal;
        }
        transform.localScale = new Vector3(0,0,0);
	}
}
