using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Global.theFogIsComing = false;
		Global.losingInterst = true;
		
		while(Global.losingInterst == true)
		{
			StartCoroutine(Global.Timeout());
			StartCoroutine(Global.IFeelPainEveryNight());
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
