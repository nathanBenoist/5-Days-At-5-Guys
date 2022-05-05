using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFog : MonoBehaviour
{
	private int mexican = 7;
	private int noEyes = 7;
	private int mexicanChance;
	private int sight;
	public static bool hope = false;
	public static bool imDoingFine = false;
	private int immigrant;
	private int bloodThurst;
	public GameObject EndMe;
	public GameObject redBull;
	public GameObject stickers;
	public GameObject war;
	
    void Start()
    {
		unmyI.dude = false;
		EndMe.SetActive(false);
		redBull.SetActive(false);
		stickers.SetActive(false);
		war.SetActive(false);
		StartCoroutine(Numb());
    }
	
	public IEnumerator Numb()
	{
		immigrant = UnityEngine.Random.Range(0,2);
		bloodThurst = UnityEngine.Random.Range(0,2);
		
		while(Global.losingInterst == true)
		{
			yield return Global.Timeout();
			yield return Global.IFeelPainEveryNight();
			yield return new WaitForSeconds(3);
			mexicanChance = UnityEngine.Random.Range(1,11);
			sight = UnityEngine.Random.Range(1, 11);
			
			if(mexican >= mexicanChance && !hope)
			{
				hope = true;
				yield return Global.HelpMe();
				immigrant = UnityEngine.Random.Range(0,2);
				
				if(immigrant == 0 && Global.cantLoveMyself == false)
				{
					Global.cantLoveMyself = true;
					EndMe.SetActive(true);
				}
				
				if(immigrant == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					redBull.SetActive(true);
				}
			}
			
			if(noEyes >= sight && !imDoingFine)
			{
				imDoingFine = true;
				yield return Global.HelpMe();
				bloodThurst = UnityEngine.Random.Range(0,2);
				
				if(bloodThurst == 0 && Global.cantLoveMyself == false)
				{
					Global.sayGoodbye = true;
					stickers.SetActive(true);
				}
				
				if(bloodThurst == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					war.SetActive(true);
				}
			}
			
			if (Global.glockCount != 8 && Global.isThereLove == false)
			{
        tell-me-why
				yield return Global.Timeout();
			}
			
			if(Global.canISeeThem == true)
			{
				Global.losingInterst = false;
				Global.dreamer = true;
			}
		}
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && hope == true)
		{
			INeedABreak();
		}
		
		if(Input.GetKeyDown(KeyCode.E) && imDoingFine == true)
		{
			bang();
		}
		
		if(Input.GetKeyDown(KeyCode.E) && hope == true || Input.GetKeyDown(KeyCode.Q) && imDoingFine == true)
		{
			Global.finna2012();
		}
    }
	
	void INeedABreak()
	{
		hope = false;
		EndMe.SetActive(false);
		redBull.SetActive(false);
		Global.cantLoveMyself = false;
		Global.sayGoodbye = false;
	}
	
	void bang()
	{
		imDoingFine = false;
		stickers.SetActive(false);
		war.SetActive(false);
		Global.cantLoveMyself = false;
		Global.sayGoodbye = false;
	}
}
