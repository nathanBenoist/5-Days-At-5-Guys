using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moleBro : MonoBehaviour
{
	private int ui = 7;
	private int mexican = 7;
	private int blind = 7;
	private int nerd = 7;
	private int moleWin = 2;
	private int moleWinSpawn;
	private int mexicanSpawn;
	private int blindSpawn;
	private int nerdSpawn;
	public static bool moleMexicanShow = false;
	public static bool moleBlindShow = false;
	public static bool moleNerdShow = false;
	public static bool moleWindowShow = false;
	private int mexicanShow;
	private int blindShow;
	private int nerdShow;
	public GameObject moleMexEn;
	public GameObject moleMaxEn;
	public GameObject moleBlindEn;
	public GameObject moleBlnEn;
	public GameObject moleNerdEn;
	public GameObject moleNardEn;
	private int showChance;
	public static bool moleShow = false;
	public GameObject moleMan;
	private int moleSpawn;
	private int ventUi = 7;
	public static bool ventShow = false;
	public GameObject ventMan;
	public AudioSource moleWinSound;
	
    void Start()
    {
        moleMexEn.SetActive(false);
		moleMaxEn.SetActive(false);
		moleBlindEn.SetActive(false);
		moleBlnEn.SetActive(false);
		moleNerdEn.SetActive(false);
		moleNardEn.SetActive(false);
		moleMan.SetActive(false);
		ventMan.SetActive(false);
		StartCoroutine(moleGuy());		
    }

	private IEnumerator moleGuy() 
	{
		while(Global.moleLad == true)
		{			
			StartCoroutine(Timer.Timeout());	
			StartCoroutine(CaffinMeter.IFeelPainEveryNight());
			yield return new WaitForSeconds(3);
			
			showChance = UnityEngine.Random.Range(1,11);
			if(showChance >= ui && !moleShow && Global.ac == true)
			{
				moleShow = true;
				StartCoroutine(Global.HelpMe());
				moleMan.SetActive(true);
			}
			
			if(showChance >= ventUi && !ventShow && Global.ac == false)
			{
				ventShow = true;
				StartCoroutine(Global.HelpMe());
				ventMan.SetActive(true);
			}
			
			mexicanSpawn = UnityEngine.Random.Range(1,11);
			blindSpawn = UnityEngine.Random.Range(1,11);
			nerdSpawn = UnityEngine.Random.Range(1,11);
			
			if(mexican >= mexicanSpawn && !moleMexicanShow && !moleBlindShow)
			{
				moleMexicanShow = true;
				StartCoroutine(Global.HelpMe());
				mexicanShow = UnityEngine.Random.Range(0,2);
				
				if(mexicanShow == 0 && Global.cantLoveMyself == false)
				{
					Global.cantLoveMyself = true;
					moleMexEn.SetActive(true);
				}
				
				if(mexicanShow == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					moleMaxEn.SetActive(true);
				}
			}		

			if(blind >= blindSpawn && !moleBlindShow && !moleMexicanShow)
			{
				moleBlindShow = true;
				StartCoroutine(Global.HelpMe());
				blindShow = UnityEngine.Random.Range(0,2);
				
				if(blindShow == 0 && Global.cantLoveMyself == false)
				{
					Global.cantLoveMyself = true;
					moleBlindEn.SetActive(true);
				}
				
				if(blindShow == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					moleBlnEn.SetActive(true);
				}
			}
			
			if(nerd >= nerdSpawn && !moleNerdShow)
			{
				moleNerdShow = true;
				StartCoroutine(Global.HelpMe());
				nerdShow = UnityEngine.Random.Range(0,2);
				
				if(nerdShow == 0 && Global.cantLoveMyself == false)
				{
					Global.cantLoveMyself = true;
					moleNerdEn.SetActive(true);
				}
				
				if(nerdShow == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					moleNardEn.SetActive(true);
				}
			}
			
			if (Timer.glockCount != 8 && Timer.isThereLove == false)
			{
				StartCoroutine(Timer.Timeout());
			}
			
			if(Global.canISeeThem == true)
			{
				SceneManager.LoadScene("Day5");
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
			moleShow = false;
			moleMan.SetActive(false);
		}
		
		else if(Input.GetKeyDown(KeyCode.F) && Global.ac == false)
		{
			Global.ac = true;
			ventShow = false;
			ventMan.SetActive(false);
		}
		
		if(Input.GetKeyDown(KeyCode.Q) && moleMexicanShow == true)
		{
			mexicanDespawn();
			nerdDespawn();
		}
		
		if(Input.GetKeyDown(KeyCode.E) && moleBlindShow == true)
		{
			blindDespawn();
			nerdDespawn();
		}
		
		if(Input.GetKeyDown(KeyCode.E) && moleMexicanShow == true || Input.GetKeyDown(KeyCode.Q) && moleBlindShow == true)
		{
			Global.finna2012();
		}
    }
	
	void mexicanDespawn()
	{
		moleMexicanShow = false;
		moleMexEn.SetActive(false);
		moleMaxEn.SetActive(false);
		Global.canISeeThem = false;
		Global.sayGoodbye = false;
	}
	
	void blindDespawn()
	{
		moleBlindShow = false;
		moleBlindEn.SetActive(false);
		moleBlnEn.SetActive(false);
		Global.canISeeThem = false;
		Global.sayGoodbye = false;
	}
	
	void nerdDespawn()
	{
		moleNerdShow = false;
		moleNerdEn.SetActive(false);
		moleNardEn.SetActive(false);
		Global.canISeeThem = false;
		Global.sayGoodbye = false;
	}
}
