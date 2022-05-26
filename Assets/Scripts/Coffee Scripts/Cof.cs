using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cof : MonoBehaviour
{	
	public AudioSource Slip;
    void Start()
    {	

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
		{
			Slip.Play();
			StartCoroutine(CaffinMeter.ThereIsNoHope());
		}
		
		if(Input.GetKeyDown(KeyCode.X))
		{
			SceneManager.LoadScene("Office");
		}
    }
}
