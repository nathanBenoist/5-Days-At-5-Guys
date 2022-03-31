using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonTest : MonoBehaviour
{
	
	public void onClick()
	{
		//Debug.Log(Global.gg); 
		SceneManager.LoadScene("Office");
	}
	
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
