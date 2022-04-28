using System;
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
	public static string gg = "GG EZ";
	public static string officeWindow = "You are now looking at the window";
	public static string officeCameras = "You are now looking at the cameras";
	public static string lazerPointer = "You blinded the poor man";
	public static string paSystem = "You scared the poor man";
	public static string windowOffice = "You are back in the office";
	public static string blindClosed = "you closed the blinds";
	public static string blindsOpen = "the blinds opened behind you";
	public static string cameraOffice = "You are back in the office";
	public static string clockMSG = "Hour went by";
	public static string gmaEnd = "Game ended";
	public static string glock = "Time end";
	public static string nard = "The nerd is here";
	public static string me = "Nard please";
	public static Timer gameClock;
	public static double cofMeter = 1;
	public static int glockCount = 7;
	
	public static void finna2012()
	{
		SceneManager.LoadScene("GameOver");
		Application.Quit();
	}
	
	public static IEnumerator IsThereATomorrow()
	{
		SceneManager.LoadScene("Day");
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene("Office");
	}
	
	public static IEnumerator HelpMe()
	{
		if(unmyI.dude == true)
		{
			yield return new WaitForSeconds(3);
			if(unmyI.dude == true)
			{
				SceneManager.LoadScene("GameOver");
				Application.Quit();
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
		Debug.Log("tiner started");
		yield return new WaitForSeconds(45);
		glockCount += 1;
		Debug.Log("Hour went by");
		
		if(glockCount == 8)
		{
			IsThereATomorrow();
		}
	}
}
