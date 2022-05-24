using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CaffinMeter : MonoBehaviour
{
	public Slider cofSlider;
	public float fillSpeed = 10f;
    public static double cofMeter = 1;
	
    void Start()
    {

    }

    void Update()
    {
        if (cofSlider.value < cofMeter)
		{
			cofSlider.value += fillSpeed * 100 * Time.deltaTime;
		}
		
		if (cofSlider.value > cofMeter)
		{
			cofSlider.value -= fillSpeed * 100 * Time.deltaTime;
		}
    }
	
	private void CEOCof()
	{
		cofSlider = gameObject.GetComponent<Slider>();
	}
	
	public void IEnumerator(float newProgress)
	{
		cofSlider.value += newProgress;
	}
	
	public static IEnumerator ThereIsNoHope()
	{
		cofMeter += .95;
		yield return new WaitForSeconds(1);
	}
	
	public static IEnumerator IFeelPainEveryNight()
	{
		if(cofMeter <= 0)
		{
			SceneManager.LoadScene("Death");
		}
		
		yield return new WaitForSeconds(2);
		cofMeter -= .2;
	}
}
