using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ba : MonoBehaviour
{
    public AudioSource death;
    void Start()
    {
		
        StartCoroutine(gameOver());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private IEnumerator gameOver()
	{
		death.Play();
		yield return new WaitForSeconds(3);
		Application.Quit();
	}
}
