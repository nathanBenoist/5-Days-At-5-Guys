﻿using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unmyI : MonoBehaviour
{
	private int ui = 7;
	private Timer deat;
	private int number;
	public static bool dude = false;
	public GameObject Nard;
	public GameObject Nerd;
	private int nardSpawn;
	

    void Start()
    {
		Nard.SetActive(false);
		Nerd.SetActive(false);
		StartCoroutine(MyEvent());
    }
	
	private IEnumerator MyEvent()
	{
		while(true)
		{
			StartCoroutine(Global.Timeout());	
			StartCoroutine(Global.IFeelPainEveryNight());
			yield return new WaitForSeconds(3);
			number = UnityEngine.Random.Range(1,11);
		
			if(ui >= number && !dude)
			{
				dude = true;
				StartCoroutine(Global.HelpMe());
				nardSpawn = UnityEngine.Random.Range(0,2);
				if(nardSpawn == 0)
				{
					Nard.SetActive(true);
				}
				
				else if(nardSpawn == 1)
				{
					Nerd.SetActive(true);
				}
				
				else
				{
					Debug.Log("Nerd spawn messed up, closing game");
					Application.Quit();
				}
			}
			
			if (Global.glockCount != 8)
			{
				StartCoroutine(Global.Timeout());
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
		Nerd.SetActive(false);
	}
}
