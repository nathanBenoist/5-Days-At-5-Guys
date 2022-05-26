using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class unmyI : MonoBehaviour
{
	private int ui = 7;
	private int number;
	public static bool dude = false;
	public GameObject Nard;
	public GameObject Nerd;
	private int nardSpawn;
	public AudioSource nerdMusic;

    void Start()
    {
		Nard.SetActive(false);
		Nerd.SetActive(false);
		StartCoroutine(MyEvent());
		nerdMusic.Play();
    }
	
	private IEnumerator MyEvent()
	{
		while(Global.theFogIsComing == true)
		{
			StartCoroutine(Timer.Timeout());	
			StartCoroutine(CaffinMeter.IFeelPainEveryNight());
			Debug.Log(CaffinMeter.cofMeter);
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
			}
			
			if (Timer.glockCount != 8 && Timer.isThereLove == false)
			{
				StartCoroutine(Timer.Timeout());
			}
			
			if(Timer.glockCount >= 8)
			{
				dude = false;
				Global.canISeeThem = false;
				Global.theFogIsComing = false;
				Global.losingInterst = true;
				SceneManager.LoadScene("Day2");
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
		dude = false;
		Global.cantLoveMyself = false;
		Global.sayGoodbye = false;
		Nard.SetActive(false);
		Nerd.SetActive(false);
	}
}
