using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightColor : MonoBehaviour {
    private float r;
    private float g;
    private float b;
    // Use this for initialization
    void Start () {
        r = 0;
        g = 0;
        b = 0;
    }
	
	// Update is called once per frame
	void Update () {
        r = ChangeColor(r);
        g = ChangeColor(g);
        b = ChangeColor(b);
        GetComponent<Light>().color = new Color(r/255, g/255, b/255, 1);
	}
    float ChangeColor(float color)
    {
        float add = 0;
        if (Random.value < 0.5f)
        {
            add = 1;
        }
        else if (Random.value < 0.75f)
        {
            add = 3;
        }
        else if (Random.value < 0.90f)
        {
            add = 5;
        }

        if (Random.value < 0.5f)
        {
            color += add;
        }
        else
        {
            color -= add;
        }
        if (color > 255)
        {
            color = 255;
        }
        else if (color < 0)
        {
            color = 0;
        }
        return color;
    }
}
