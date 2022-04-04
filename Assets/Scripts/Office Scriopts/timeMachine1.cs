using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeMachine1 : MonoBehaviour
{
	private static Timer gameClock;
	
    void Start()
    {
		gameClock = new System.Timers.Timer();
		for(int i = 0; i < 8; i++)
		{
			gameClock.Interval = 60000;
			gameClock.Elapsed += OnTimedEvent;
			gameClock.Enabled = true;
		}
		
		void OnTimedEvent(System.Object source, System.Timers.ElapsedEventArgs e)
		{
			Debug.Log(Global.clockMSG);
		}
    }

    void Update()
    {
        
    }
}
