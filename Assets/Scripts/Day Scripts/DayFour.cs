using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayFour : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Day());
    }

    void Update()
    {
        
    }
	
	private IEnumerator Day()
	{
		yield return new WaitForSeconds(3);
		CaffinMeter.cofMeter = 1;
		Timer.glockCount = 0;
		SceneManager.LoadScene("Office");
	}
}
