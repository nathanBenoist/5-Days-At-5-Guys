﻿using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class globalVars : MonoBehaviour
{
}

public static class Global
{
	public static Timer gameClock;
	public static double cofMeter = 1;
	public static int glockCount = 7;
	public static bool isThereLove = false;
	public static bool canISeeThem = false;
	public static bool theFogIsComing = true;
	public static bool losingInterst = false;
	public static bool dreamer = false;
	public static bool cantLoveMyself = false;
	public static bool sayGoodbye = false;
	public static bool ac = false;
	
	public static void finna2012()
	{
		SceneManager.LoadScene("GameOver");
		Application.Quit();
	}
	
	public static IEnumerator IsThereATomorrow()
	{
		canISeeThem = false;
		SceneManager.LoadScene("Day");
		yield return new WaitForSeconds(0);
	}
	
	public static IEnumerator HelpMe()
	{
		if(unmyI.dude == true)
		{
			yield return new WaitForSeconds(3);
			if(unmyI.dude == true)
			{
				finna2012();
			}
		}	
		if(TheFog.hope == true)
		{
			yield return new WaitForSeconds(3);
			if(TheFog.hope == true)
			{
				finna2012();
			}
		}
		if(TheFog.imDoingFine == true)
		{
			yield return new WaitForSeconds(3);
			if(TheFog.imDoingFine == true)
			{
				finna2012();
			}
		}
		if(Bazos.notAsRichAsElon == true)
		{
			yield return new WaitForSeconds(3);
			if(Bazos.notAsRichAsElon == true)
			{
				finna2012();
			}
		}
	}
	
	public static IEnumerator IFeelPainEveryNight()
	{
		yield return new WaitForSeconds(2);
		cofMeter -= .2;
	}
	
	public static IEnumerator ThereIsNoHope()
	{
		cofMeter += .95;
		yield return new WaitForSeconds(1);
	}
	
	public static IEnumerator Timeout()
	{
		isThereLove = true;
		Debug.Log("tiner started");
		yield return new WaitForSeconds(30);
		glockCount += 1;
		Debug.Log("Hour went by");
		isThereLove = false;
		
		if(glockCount == 8)
		{
			canISeeThem = true;
		}
	}
	
	public static IEnumerator MaybeTodayWillBeBetter()
	{
		yield return new WaitForSeconds(3);
		cofMeter = 1;
		glockCount = 0;
		SceneManager.LoadScene("Office");
	}
}
