using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazos : MonoBehaviour
{
	private int money = 7;
	private int billion;
	public static bool notAsRichAsElon = false;
	
    void Start()
    {
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
