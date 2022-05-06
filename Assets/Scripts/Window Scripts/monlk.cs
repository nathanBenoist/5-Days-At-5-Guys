using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monlk : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
		{
			SceneManager.LoadScene("Office");
		}
		
		if(Input.GetKeyDown(KeyCode.R))
		{
			//Debug.Log(Global.blindClosed);
		}
    }
}
