using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bazos : MonoBehaviour
{
	private int money = 3;
	private int mexican = 7;
	private int blind = 7;
	private int nerd = 7;
	private int billion;
	private int mexicanSpawn;
	private int blindSpawn;
	private int nerdSpawn;
	public static bool bazosMexicanShow = false;
	public static bool bazosBlindShow = false;
	public static bool bazosNerdShow = false;
	private int mexicanShow;
	private int blindShow;
	private int nerdShow;
	public GameObject mexEn;
	public GameObject maxEn;
	public GameObject blindEn;
	public GameObject bldEn;
	public GameObject nerdEn;
	public GameObject nardEn;
	public AudioSource windowMusic;
	public AudioSource windowKnock;
	
	public static bool notAsRichAsElon = false;
	
    void Start()
    {
		mexEn.SetActive(false);
		maxEn.SetActive(false);
		blindEn.SetActive(false);
		bldEn.SetActive(false);
		nerdEn.SetActive(false);
		nardEn.SetActive(false);
		StartCoroutine(mrKrabs());
		windowMusic.Play();
    }
	
	private IEnumerator mrKrabs()
	{
		while(Global.dreamer == true)
		{
			StartCoroutine(Timer.Timeout());	
			StartCoroutine(CaffinMeter.IFeelPainEveryNight());
			yield return new WaitForSeconds(3);
			billion = UnityEngine.Random.Range(1, 11);
			
			if(money >= billion && !notAsRichAsElon)
			{
				notAsRichAsElon = true;
				StartCoroutine(Global.HelpMe());
				windowMusic.Stop();
				windowKnock.Play();
			}
			
			mexicanSpawn = UnityEngine.Random.Range(1,11);
			blindSpawn = UnityEngine.Random.Range(1,11);
			nerdSpawn = UnityEngine.Random.Range(1,11);
			
			if(mexican >= mexicanSpawn && !bazosMexicanShow && !bazosBlindShow)
			{
				bazosMexicanShow = true;
				StartCoroutine(Global.HelpMe());
				mexicanShow = UnityEngine.Random.Range(0,2);
				
				if(mexicanShow == 0 && Global.cantLoveMyself == false)
				{
					Global.cantLoveMyself = true;
					mexEn.SetActive(true);
				}
				
				if(mexicanShow == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					maxEn.SetActive(true);
				}
			}
				
			if(blind >= blindSpawn && !bazosBlindShow && !bazosMexicanShow)
			{
				bazosBlindShow = true;
				StartCoroutine(Global.HelpMe());
				blindShow = UnityEngine.Random.Range(0,2);
				
				if(blindShow == 0 && Global.cantLoveMyself == false)
				{
					Global.cantLoveMyself = true;
					blindEn.SetActive(true);
				}
				
				if(blindShow == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					bldEn.SetActive(true);
				}
			}
			
			if(nerd >= nerdSpawn && !bazosNerdShow) 
			{
				bazosNerdShow = true;
				StartCoroutine(Global.HelpMe());
				nerdShow = UnityEngine.Random.Range(0,2);
				
				if(nerdShow == 0 && Global.cantLoveMyself == false)
				{
					Global.cantLoveMyself = true;
					nerdEn.SetActive(true);
				}
				
				if(nerdShow == 1 && Global.sayGoodbye == false)
				{
					Global.sayGoodbye = true;
					nardEn.SetActive(true);
				}
				
			}
			
			if (Timer.glockCount != 8 && Timer.isThereLove == false)
			{
				StartCoroutine(Timer.Timeout());
			}
			
			if(Timer.glockCount >= 8)
			{
				SceneManager.LoadScene("Day4");
				Global.canISeeThem = false;
				Global.dreamer = false;
				Global.moleLad = true;
			}
		}
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && bazosMexicanShow == true || Input.GetKeyDown(KeyCode.Q) && bazosNerdShow == true)
		{
			mexicanDespawn();
			nerdDespawn();
		}
		
		if(Input.GetKeyDown(KeyCode.E) && bazosBlindShow == true || Input.GetKeyDown(KeyCode.E) && bazosNerdShow == true)
		{
			blindDespawn();
			nerdDespawn();
		}
		
		if(Input.GetKeyDown(KeyCode.E) && bazosMexicanShow == true || Input.GetKeyDown(KeyCode.Q) && bazosBlindShow == true)
		{
			Global.finna2012();
		}
    }
	
	void mexicanDespawn()
	{
		bazosMexicanShow = false;
		mexEn.SetActive(false);
		maxEn.SetActive(false);
		Global.canISeeThem = false;
		Global.sayGoodbye = false;
	}
	
	void blindDespawn()
	{
		bazosBlindShow = false;
		blindEn.SetActive(false);
		bldEn.SetActive(false);
		Global.canISeeThem = false;
		Global.sayGoodbye = false;
	}
	
	void nerdDespawn()
	{
		bazosNerdShow = false;
		nerdEn.SetActive(false);
		nardEn.SetActive(false);
		Global.canISeeThem = false;
		Global.sayGoodbye = false;
	}	
}
