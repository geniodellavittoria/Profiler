using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowCode : MonoBehaviour {

    float timeValueRed;
    float timeValueGreen;
    float timeValueBlue;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Renderer>().material.color = ColorForTime();
        DoLoop();
        DoSomethingElse();
	}

    void DoLoop()
    {
        for(int i =0; i< 1000; i++)
        {
            GetComponent<Renderer>().material.color = ColorForTime();
        }
    }

    void DoSomethingElse()
    {
        Debug.Log("look how slow logging is");
    }

    private Color ColorForTime()
    {
        timeValueRed += Time.deltaTime;
        if (timeValueRed > 1f)
            timeValueRed -= 1f;
        timeValueGreen += Time.deltaTime * 2f;
        if (timeValueGreen > 1f)
            timeValueGreen -= 1f;
        timeValueBlue = Time.deltaTime * 3f;
        if (timeValueBlue > 1f)
            timeValueBlue -= 1f;
        return new Color(timeValueRed, timeValueGreen, timeValueBlue);
    }
}
