using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffKeyB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
		{
			Debug.Log(Global.lazerPointer);
		}
		
		if(Input.GetKeyDown(KeyCode.E))
		{
			Debug.Log(Global.paSystem);
		}
    }
}
