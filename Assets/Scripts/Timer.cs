using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public static int glockCount = 0;
	public static bool isThereLove = false;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        
    }
	
	public static IEnumerator Timeout()
	{
		isThereLove = true;
		Debug.Log("tiner started");
		yield return new WaitForSeconds(15);
		glockCount += 1;
		Debug.Log("Hour went by");
		Debug.Log(glockCount);
		isThereLove = false;
		
		if(glockCount == 8)
		{
			Global.canISeeThem = true;
		}
	}
}
