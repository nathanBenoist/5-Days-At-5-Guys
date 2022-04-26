using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeMachine1 : MonoBehaviour
{
	
    void Start()
    {
		Global.gameClock = new System.Timers.Timer();

		Global.gameClock.Interval = 60000;
		Global.gameClock.Elapsed += OnTimedEvent;
		Global.gameClock.Enabled = true;
		
		void OnTimedEvent(System.Object source, System.Timers.ElapsedEventArgs e)
		{
			Debug.Log(Global.clockMSG);
			Global.gameClock.Stop();
			globalBeans.glockCount += 1;
			
			if(globalBeans.glockCount != 8)
			{
				Global.gameClock.Start();
			}
			
			else if(globalBeans.glockCount == 8)
			{
				Global.IsThereATomorrow();
			}
		}
    }

    void Update()
    {
        Debug.Log(globalBeans.cofMeter);
		
		if(globalBeans.cofMeter <= 0 || globalBeans.cofMeter >= 8)
		{
			Global.finna2012();
		}
    }
}
