﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moleBro : MonoBehaviour
{
	private int ui = 7;
	private int showChance;
	public static bool moleShow = false;
	public GameObject moleMan;
	private int moleSpawn;
	
    void Start()
    {
        moleMan.SetActive(false);
		StartCoroutine(moleGuy());		
    }

	public IEnumerator moleGuy() 
	{
		while(Global.moleLad == false)
		{
			yield return Global.Timeout();	
			yield return Global.IFeelPainEveryNight();
			yield return new WaitForSeconds(3);
			
			showChance = UnityEngine.Random.Range(1,11);
			if(showChance >= ui && !moleShow && Global.ac == true)
			{
				moleShow = true;
				yield return Global.HelpMe();
				moleMan.SetActive(true);
			}
			
			if (Global.glockCount != 8 && Global.isThereLove == false)
			{
				yield return Global.Timeout();
			}
			
			if(Global.canISeeThem == true)
			{
				yield return Global.IsThereATomorrow();
				Global.canISeeThem = false;
				Global.moleLad = false;
				Global.commie = true;
			}
		}
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && Global.ac == true)
		{
			Global.ac = false;
		}
		
		else if(Input.GetKeyDown(KeyCode.F) && Global.ac == false)
		{
			Global.ac = true
		}
    }
}
