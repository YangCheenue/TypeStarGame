﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private int currentTime;
    private Text textObject;
    private string text;
	// Use this for initialization
	void Start () {
        currentTime = (int)Time.time;
        textObject = GetComponent<Text>();
        text = "Time: " + currentTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentTime = (int)Time.time;
        text = "Time: " + currentTime;
        textObject.text = text;
	}
}
