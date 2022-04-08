using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unmyI : MonoBehaviour
{
	private int ui = 10;
	private Timer deat;
	private int number;
	private bool dude = false;

    void Start()
    {
		Debug.Log("nard on way");
        deat = new System.Timers.Timer();
		Debug.Log("Timer created");
		
		deat.Interval = 2000;
		deat.Elapsed += OnTimedEvent;
		deat.Enabled = true;
		
		void OnTimedEvent(System.Object source, System.Timers.ElapsedEventArgs e)
		{
			Debug.Log("OnTimedEvent running");
			
			Debug.Log("Creating number");
			number = System.Random.Range(1,11);
			Debug.Log("MAYBE NUMBER???");
			
			if(ui >= number)
			{
				Debug.Log(Global.nard);
				dude = true;
			}
			
			deat.Stop();
			deat.Start();
		}
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && dude == true)
		{
			Debug.Log(Global.lazerPointer);
			dude = false;
		}
		
		if(Input.GetKeyDown(KeyCode.E) && dude == true)
		{
			Debug.Log(Global.paSystem);
			dude = false;
		}
    }
}
