using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBoss : MonoBehaviour
{
	private int russianUI = 9;
	private int mexicanUI = 9;
	private int moleUI = 9;
	private int nerdUI = 9;
	private int windowUI = 9;
	private int blindUI = 9;
	public static bool russianShow = false;
	public static bool rusBlind = false;
	public static bool rusMexican = false;
	public static bool rusMole = false;
	public static bool rusNerd = false;
	public static bool rusWin = false;
	private int rusShowChance;
	private int mexShowChance;
	private int moleShowChance;
	private int nerdShowChance;
	private int winShowChance;
	private int blindShowChance;
	public GameObject rusMexEn;
	public GameObject rusMaxEn;
	public GameObject rusBlindEn;
	public GameObject rusBlnEn;
	public GameObject rusMoleEn;
	public GameObject rusWinEn;
	public GameObject rusNerdEn;
	public GameObject rusNardEn;
	private int rusSpawn;
	private int mexSpawn;
	private int moleSpawn;
	private int nerdSpawn;
	private int blindSpawn;
	
    void Start()
    {
        rusMexEn.SetActive(false);
		rusMaxEn.SetActive(false);
		rusBlindEn.SetActive(false);
		rusBlnEn.SetActive(false);
		rusMoleEn.SetActive(false);
		rusWinEn.SetActive(false);
		rusNerdEn.SetActive(false);
		rusNardEn.SetActive(false);
		StartCoroutine(death());
    }

	private IEnumerator death()
	{
		while(Global.commie == true)
		{
			StartCoroutine(Timer.Timeout());	
			StartCoroutine(CaffinMeter.IFeelPainEveryNight());
			yield return new WaitForSeconds(3);
			
			mexShowChance = UnityEngine.Random.Range(1,11);
			if(mexicanUI >= mexShowChance && !russianShow && !rusBlind)
			{
				russianShow = true;
				StartCoroutine(Global.HelpMe());
				mexSpawn = UnityEngine.Random.Range(0,2);
				
				if(mexSpawn == 0 && Global.cantLoveMyself == false)
				{
					Global.cantLoveMyself = true;
					rusMexEn.SetActive(true);
				}
				
				if(mexSpawn == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					rusMaxEn.SetActive(true);
				}
			}
			
			blindShowChance = UnityEngine.Random.Range(1, 11);
			if(blindUI >= blindShowChance && !rusBlind && !russianShow)
			{
				rusBlind = true;
				StartCoroutine(Global.HelpMe());
				blindSpawn = UnityEngine.Random.Range(0, 2);
				
				if(blindSpawn == 0 && Global.cantLoveMyself == false)
				{
					Global.cantLoveMyself = true;
					rusBlindEn.SetActive(true);
				}
				
				if(blindSpawn == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					rusBlnEn.SetActive(true);
				}
			}
			
			nerdShowChance = UnityEngine.Random.Range(1, 11);
			if(nerdUI >= nerdShowChance && !rusNerd)
			{
				rusNerd = true;
				StartCoroutine(Global.HelpMe());
				nerdSpawn = UnityEngine.Random.Range(0,2);
				
				if(nerdSpawn == 0 && Global.cantLoveMyself == false)
				{
					Global.cantLoveMyself = true;
					rusNerdEn.SetActive(true);
				}
				
				if(nerdSpawn == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					rusNardEn.SetActive(true);
				}
			}
			
			moleShowChance = UnityEngine.Random.Range(1, 11);
			if(moleUI >= moleShowChance && !rusMole)
			{
				rusMole = true;
				StartCoroutine(Global.HelpMe());
				rusMoleEn.SetActive(true);
			}
			
			if (Timer.glockCount != 8 && Timer.isThereLove == false)
			{
				StartCoroutine(Timer.Timeout());
			}
			
			if(Global.canISeeThem == true)
			{
				Application.Quit();
			}				
		}
	}

    void Update()
    {
		
	}
		void mexicanDespawn()
		{
			rusMexican= false;
			rusMexEn.SetActive(false);
			rusMaxEn.SetActive(false);
			Global.canISeeThem = false;
			Global.sayGoodbye = false;
		}
		
		void blindDespawn()
		{
			rusBlind = false;
			rusBlindEn.SetActive(false);
			rusBlnEn.SetActive(false);
			Global.canISeeThem = false;
			Global.sayGoodbye = false;
		}
		
		void nerdDespawn()
		{
			rusNerd = false;
			rusNerdEn.SetActive(false);
			rusNardEn.SetActive(false);
			Global.canISeeThem = false;
			Global.sayGoodbye = false;
		}
}
