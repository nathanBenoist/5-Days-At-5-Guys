﻿using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unmyI : MonoBehaviour
{
	private int ui = 6;
	private Timer deat;
	private int number;
	private bool dude = false;
	public GameObject Nard;
	

    void Start()
    {
		Nard.SetActive(false);
		StartCoroutine(MyEvent());
    }
	
	private IEnumerator MyEvent()
	{
		while(true)
		{
			Debug.Log("Waiting 2 sec");
			yield return new WaitForSeconds(5);
			Debug.Log("Creating number");
			number = UnityEngine.Random.Range(1,11);
			Debug.Log("Number made");
		
			if(ui >= number && !dude)
			{
				Debug.Log(Global.nard);
				dude = true;
				Nard.SetActive(true);
			}
		} 
	}
	
    void Update()
    {	
		if(Input.GetKeyDown(KeyCode.Q) && dude == true)
		{
			Help();
		}
		
		if(Input.GetKeyDown(KeyCode.E) && dude == true)
		{
			Help();
		}
    }
	
	void Help()
	{
		Debug.Log(Global.me);
		dude = false;
		Nard.SetActive(false);
	}
}
