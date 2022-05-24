using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Day());
    }

    // Update is called once per frame
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
