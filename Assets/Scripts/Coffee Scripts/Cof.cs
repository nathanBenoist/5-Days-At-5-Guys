using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cof : MonoBehaviour
{
	public double cofMeter = .5;
	private static Timer beans;
	
    void Start()
    {	
		beans = new System.Timers.Timer();
		beans.Interval = 5000;
		beans.Elapsed += OnTimedEvent;
		beans.Enabled = true;
		
		void OnTimedEvent(System.Object source, System.Timers.ElapsedEventArgs e)
		{
			cofMeter -= .15;
			beans.Stop();
			beans.Start();
		}
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log(cofMeter);
		
        if(Input.GetKeyDown(KeyCode.Z))
		{
			cofMeter += .03;
		}
		if(cofMeter <= 0)
		{
			Debug.Log(Global.gmaEnd);
		}
    }
}
