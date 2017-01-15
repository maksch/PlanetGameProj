using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempoChecker : MonoBehaviour {
    public string keyToCheckInput;
    public Text inputResultText;
    private bool isColliding;
    private bool isParalysed;
    private static float timeSincePress;
    private int currentState;
	// Use this for initialization
	void Start () {
        isParalysed = false;
        isColliding = false;
        timeSincePress = 0;
        currentState = 3;
    }
	void FixedUpdate()
    {

        timeSincePress += Time.deltaTime;
        if (timeSincePress > 2f)
        {
            inputResultText.text = "Status";
        }
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(keyToCheckInput) && !isParalysed) {
            timeSincePress = 0;
            switch (currentState)
            {
                case 0: inputResultText.text = "PERFECT " + keyToCheckInput; break;
                case 1: inputResultText.text = "GOOD " + keyToCheckInput; break;
                case 2: inputResultText.text = "BAD " + keyToCheckInput; break;
                case 3: inputResultText.text = "MISS " + keyToCheckInput; break;
                default: inputResultText.text = "ERROR " + keyToCheckInput; break;
            }
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "PerfectHitbox")
        {
            currentState = 0;
        }
        else if (c.gameObject.tag == "GoodHitbox")
        {
            currentState = 1;
        }
        else if (c.gameObject.tag == "BadHitbox")
        {
            currentState = 2;
        }
        isColliding = true;
    }
    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "ExitHitbox")
        {
            isColliding = false;
            isParalysed = false;
            currentState = 3;
        }
    }
}
