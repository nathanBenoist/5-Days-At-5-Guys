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
	
	
    void Start()
    {
    }
	
	private IEnumerator Numb()
	{
		Global.theFogIsComing = false;
		Global.losingInterst = true;
		immigrant = UnityEngine.Random.Range(0,2);
		bloodThurst = UnityEngine.Random.Range(0,2);
		
		while(Global.losingInterst == true)
		{
			StartCoroutine(Global.Timeout());
			StartCoroutine(Global.IFeelPainEveryNight());
			yield return new WaitForSeconds(3);
			mexicanChance = UnityEngine.Random.Range(1,11);
			sight = UnityEngine.Random.Range(1, 11);
			
			if(mexican >= mexicanChance && !hope)
			{
				hope = true;
				StartCoroutine(Global.HelpMe());
			}
			
			if(noEyes >= sight && !imDoingFine)
			{
				imDoingFine = true;
				StartCoroutine(Global.HelpMe());
			}
		}
	}

    void Update()
    {
        
    }
}
