using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cof : MonoBehaviour
{	
    void Start()
    {	

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
		{
			globalBeans.cofMeter += .03;
		}
		if(globalBeans.cofMeter <= 0)
		{
			Debug.Log(Global.gmaEnd);
		}
    }
}
