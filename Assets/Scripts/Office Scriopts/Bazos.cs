using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazos : MonoBehaviour
{
	private int money = 7;
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
    }
	
	public IEnumerator mrKrabs()
	{
		while(Global.dreamer == true)
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
				
				mexicanSpawn = UnityEngine.Random.Range(1,11);
				blindSpawn = UnityEngine.Random.Range(1,11);
				nerdSpawn = UnityEngine.Random.Range(1,11);
				
				if(mexican >= mexicanSpawn && !bazosMexicanShow && !bazosBlindShow)
				{
					bazosMexicanShow = true;
					yield return Global.HelpMe();
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
					yield return Global.HelpMe();
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
					yield return Global.HelpMe();
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
					
				
				if (Global.glockCount != 8 && Global.isThereLove == false)
				{
					yield return Global.Timeout();
				}
				
				if(Global.canISeeThem == false)
				{
					yield return Global.IsThereATomorrow();
					Global.canISeeThem = false;
					Global.dreamer = false;
					Global.moleLad = true;
				}
			}
		}
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && mexicanShow == true)
		{
			mexicanDespawn();
			nerdDespawn();
		}
		
		if(Input.GetKeyDown(KeyCode.E) && blindShow == true)
		{
			blindShow();
			nerdDespawn();
		}
		
		if(Input.GetKeyDown(KeyCode.E) && mexicanShow == true || Input.GetKeyDown(KeyCode.Q) && blindShow == true)
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
