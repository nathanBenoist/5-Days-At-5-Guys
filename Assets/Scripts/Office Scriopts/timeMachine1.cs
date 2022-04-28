using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeMachine1 : MonoBehaviour
{
	
    void Start()
    {
		StartCoroutine(Global.Timeout());
    }

    void Update()
    {
        Debug.Log(Global.cofMeter);
		
		if(Global.cofMeter <= 0 || Global.cofMeter >= 8)
		{
			Global.finna2012();
		}
    }
}
