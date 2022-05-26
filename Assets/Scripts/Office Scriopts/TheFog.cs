using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheFog : MonoBehaviour
{
	private int mexican = 7;
	private int noEyes = 7;
	private int nerdUi = 7;
	private int mexicanChance;
	private int sight;
	private int nerdShow;
	public static bool hope = false;
	public static bool imDoingFine = false;
	public static bool fogNerdShow = false;
	private int immigrant;
	private int bloodThurst;
	private int nerdSpawn;
	public GameObject EndMe;
	public GameObject redBull;
	public GameObject stickers;
	public GameObject war;
	public GameObject fogNerd;
	public GameObject fogNard;
	public AudioSource fogMusic;
	
    void Start()
    {
		fogNerd.SetActive(false);
		fogNard.SetActive(false);
		EndMe.SetActive(false);
		redBull.SetActive(false);
		stickers.SetActive(false);
		war.SetActive(false);
		StartCoroutine(Numb());
		fogMusic.Play();
    }
	
	private IEnumerator Numb()
	{	
		while(Global.losingInterst == true)
		{
			StartCoroutine(Timer.Timeout());
			StartCoroutine(CaffinMeter.IFeelPainEveryNight());
			yield return new WaitForSeconds(3);
			mexicanChance = UnityEngine.Random.Range(1,11);
			sight = UnityEngine.Random.Range(1, 11);
			nerdShow = UnityEngine.Random.Range(1,11);
			
			if(mexican >= mexicanChance && !hope && !imDoingFine)
			{
				hope = true;
				StartCoroutine(Global.HelpMe());
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
			
			if(noEyes >= sight && !imDoingFine && !hope)
			{
				imDoingFine = true;
				StartCoroutine(Global.HelpMe());
				bloodThurst = UnityEngine.Random.Range(0,2);
				
				if(bloodThurst == 0 && Global.cantLoveMyself == false)
				{
					Global.cantLoveMyself = true;
					stickers.SetActive(true);
				}
				
				if(bloodThurst == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					war.SetActive(true);
				}
			}
			
			if(nerdUi >= nerdShow && !fogNerdShow)
			{
				fogNerdShow = true;
				StartCoroutine(Global.HelpMe());
				nerdSpawn = UnityEngine.Random.Range(0,2);
				
				if(nerdSpawn == 0 && Global.cantLoveMyself == false)
				{
					Global.cantLoveMyself = true;
					fogNerd.SetActive(true);
				}
				
				if(nerdShow == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					fogNard.SetActive(true);
				}
			}
			
			if (Timer.glockCount != 8 && Timer.isThereLove == false)
			{
				StartCoroutine(Timer.Timeout());
			}
			
			if(Timer.glockCount >= 8)
			{
				hope = false;
				imDoingFine = false;
				Global.cantLoveMyself = false;
				Global.sayGoodbye = false;
				SceneManager.LoadScene("Day3");
				Global.canISeeThem = false;
				Global.losingInterst = false;
				Global.dreamer = true;
			}
		}
	} 

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && hope == true || Input.GetKeyDown(KeyCode.Q) && fogNerdShow == true)
		{
			INeedABreak();
			nerdDespawn();
		}
		
		if(Input.GetKeyDown(KeyCode.E) && imDoingFine == true || Input.GetKeyDown(KeyCode.E) && fogNerdShow == true) 
		{
			bang();
			nerdDespawn();
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
	
	void nerdDespawn()
	{
		fogNerdShow = false;
		fogNard.SetActive(false);
		fogNerd.SetActive(false);
		Global.cantLoveMyself = false;
		Global.sayGoodbye = false;
	}
}
