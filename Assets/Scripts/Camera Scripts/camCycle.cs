using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camCycle : MonoBehaviour
{
	public List<GameObject> CamCycle;
	private int coke = 0;
	
    void Start()
    {
		Bonk();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			coke += 1;
			if(coke >= CamCycle.Count)
			{
				coke = 0;
			}
			
			Bonk();
			CamCycle[coke].SetActive(true);
		}
		
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			coke -= 1;
			if(coke < 0)
			{
				coke = CamCycle.Count - 1;
			}
			
			Bonk();
			CamCycle[coke].SetActive(true);
		}
    }
	
	void Bonk()
	{
		for(int i = 0; i < CamCycle.Count; i++)
		{
			CamCycle[i].SetActive(false);
		}
	}
}
