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
	public static string clockMSG = "Something happpend";
	public static string gmaEnd = "Game ended";
	public static string glock = "Time end";
	public static string nard = "The nerd is here";
	public static string me = "Nard please";
	public static Timer beans;
	public static Timer gameClock;
	
	public static void finna2012()
	{
		SceneManager.LoadScene("GameOver");
		Application.Quit();
	}
}

public class globalBeans
{
	public static double cofMeter = .5;
	public static int glockCount = 0;
}
