using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazos : MonoBehaviour
{
	private int money = 7;
	private int billion;
	public static bool notAsRichAsElon = false;
	public GameObject bazos;
	public GameObject baezos;
	private int moneyCave;
	
    void Start()
    {
        
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
				yield return Global.HelpMe()
				moneyCave = UnityEngine.Random.Range(0, 2);
				
				if(moneyCave == 0)
				{
					bazos.SetActive(true);
				}
				
				if(moneyCave == 1)
				{
					baezos.SetActive(true);
				}
			}
		}
	}

    void Update()
    {
        
    }
}
