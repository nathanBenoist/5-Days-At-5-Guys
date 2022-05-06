using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bazosMad : MonoBehaviour
{
	public GameObject bazos;
	public GameObject hiddenFromLife;
	
    void Start()
    {
        if(Bazos.notAsRichAsElon == true)
		{
			bazos.SetActive(true);
		}
    }

    void Update()
    {
		if(Input.GetKeyDown(KeyCode.R))
		{
			StartCoroutine(badBazos());
		}
    }
	
	private IEnumerator badBazos()
	{
		hiddenFromLife.SetActive(true);
			
		if(Bazos.notAsRichAsElon == true)
		{
			Bazos.notAsRichAsElon = false;
			bazos.SetActive(false);
		}
		
		yield return new WaitForSeconds(1);
		hiddenFromLife.SetActive(false);
	}
}