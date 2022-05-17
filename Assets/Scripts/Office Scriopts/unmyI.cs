using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unmyI : MonoBehaviour
{
	private int ui = 7;
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
	
	public IEnumerator MyEvent()
	{
		while(Global.theFogIsComing == true)
		{
			yield return Global.Timeout();	
			yield return Global.IFeelPainEveryNight();
			yield return new WaitForSeconds(3);
			number = UnityEngine.Random.Range(1,11);
			
			if(ui >= number && !dude)
			{
				dude = true;
				yield return Global.HelpMe();
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
			
			if (Global.glockCount != 8 && Global.isThereLove == false)
			{
				yield return Global.Timeout();
			}
			
			if(Global.canISeeThem == true)
			{
				yield return Global.IsThereATomorrow();
				Global.canISeeThem = false;
				Global.theFogIsComing = false;
				Global.losingInterst = true;
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
