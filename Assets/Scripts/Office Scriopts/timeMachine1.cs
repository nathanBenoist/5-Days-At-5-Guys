using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeMachine1 : MonoBehaviour
{
	private static Timer timeClock;
	
    void Start()
    {
		Debug.Log("UR MOM");
        timeClock = new System.Timers.Timer();
		timeClock.Interval = 10000;
		timeClock.Elapsed += OnTimedEvent;
		timeClock.Enabled = true;
    }

		private static void OnTimedEvent(System.Object source, System.Timers.ElapsedEventArgs e)
    {
        Debug.Log("Timer ended");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
