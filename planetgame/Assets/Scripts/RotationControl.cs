using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationControl : MonoBehaviour {
    public float xRotateAngle;
    public float yRotateAngle;
    public float zRotateAngle;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(xRotateAngle, yRotateAngle, zRotateAngle);
	}
}
