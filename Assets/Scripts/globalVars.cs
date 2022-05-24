using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class globalVars : MonoBehaviour
{
}

public static class Global
{
	public static bool canISeeThem = false;
	public static bool theFogIsComing = false; // change to true
	public static bool losingInterst = false;
	public static bool dreamer = false;
	public static bool cantLoveMyself = false;
	public static bool sayGoodbye = false;
	public static bool ac = false;
	public static bool moleLad = false;
	public static bool commie = false;
	
	public static void finna2012()
	{
		SceneManager.LoadScene("GameOver");
		Application.Quit();
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
		if(moleLad == true)
		{
			yield return new WaitForSeconds(3);
			if(moleBro.moleShow == true || moleBro.ventShow == true)
			{
				finna2012();
			}
		}
	}
	
	public static IEnumerator MaybeTodayWillBeBetter()
	{
		yield return new WaitForSeconds(3);
		CaffinMeter.cofMeter = 1;
		Timer.glockCount = 0;
		SceneManager.LoadScene("Office");
	}
}
