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
        
    }
}
