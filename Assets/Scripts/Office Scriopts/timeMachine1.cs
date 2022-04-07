using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeMachine1 : MonoBehaviour
{
	private static Timer gameClock;
	private int glockCount = 0;
	
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
			glockCount += 1;
			
			if(glockCount != 8)
			{
				gameClock.Start();
			}
		}
		
		Global.beans = new System.Timers.Timer();
		Global.beans.Interval = 5000;
		Global.beans.Elapsed += caffineAddict;
		Global.beans.Enabled = true;
		
		void caffineAddict(System.Object source, System.Timers.ElapsedEventArgs e)
		{
			globalBeans.cofMeter -= .15;
			Global.beans.Stop();
			Global.beans.Start();
		}
    }

    void Update()
    {
        Debug.Log(globalBeans.cofMeter);
    }
}
