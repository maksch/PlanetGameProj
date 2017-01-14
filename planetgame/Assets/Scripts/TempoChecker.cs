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
	// Use this for initialization
	void Start () {
        isParalysed = false;
        isColliding = false;
        timeSincePress = 0;

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
            if (isColliding)
            {
                isParalysed = true;
                inputResultText.text = "HIT " + keyToCheckInput;
            }
            else
            {
                inputResultText.text = "MISS " + keyToCheckInput;
            }
        }
        
    }

    void OnTriggerEnter(Collider c)
    {
        isColliding = true;
    }
    void OnTriggerExit(Collider c)
    {
        isColliding = false;
        isParalysed = false;
    }
}
