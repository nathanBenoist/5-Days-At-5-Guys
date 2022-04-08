using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cof : MonoBehaviour
{	
    void Start()
    {	

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
		{
			globalBeans.cofMeter += .03;
		}
		
		if(Input.GetKeyDown(KeyCode.X))
		{
			SceneManager.LoadScene("Office");
		}
    }
}
