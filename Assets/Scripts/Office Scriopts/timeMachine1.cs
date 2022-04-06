using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeMachine1 : MonoBehaviour
{
	private static Timer gameClock;
	private glockCount = 0;
	
    void Start()
    {
		gameClock = new System.Timers.Timer();

		gameClock.Interval = 60000;
		gameClock.Elapsed += OnTimedEvent;
		gameClock.Enabled = true;
		
		void OnTimedEvent(System.Object source, System.Timers.ElapsedEventArgs e)
		{
			Debug.Log(Global.clockMSG);
			gameClock.Stop();
			GlockCount += 1;
			
			if(GlockCount != 8)
			{
				gameClock.Start();
			}
			
		}
    }

    void Update()
    {
        
    }
}
