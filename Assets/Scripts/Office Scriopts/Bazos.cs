﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazos : MonoBehaviour
{
	private int money = 7;
	private int billion;
	public static bool notAsRichAsElon = false;
	
    void Start()
    {
        unmyI.dude = false;
		TheFog.hope = false;
		TheFog.imDoingFine = false;
		UnmyI.Nerd.SetActive(false);
		UnmyI.Nard.SetActive(false);
		TheFog.EndMe.SetActive(false);
		TheFog.redBull.SetActive(false);
		TheFog.stickers.SetActive(false);
		TheFog.war.SetActive(false);
		StartCoroutine(unmyI.MyEvent());
		StartCoroutine(TheFog.Numb());
		StartCoroutine(mrKrabs());
    }
	
	public IEnumerator mrKrabs()
	{
		while(Global.losingInterst == true)
		{
			yield return Global.Timeout();	
			yield return Global.IFeelPainEveryNight();
			yield return new WaitForSeconds(3);
			billion = UnityEngine.Random.Range(1, 11);
			
			if(money >= billion && !notAsRichAsElon)
			{
				notAsRichAsElon = true;
				yield return Global.HelpMe();
				
				Debug.Log("Give me my power back");
				
				if (Global.glockCount != 8 && Global.isThereLove == false)
				{
					yield return Global.Timeout();
				}
			}
		}
	}

    void Update()
    {
        
    }
}