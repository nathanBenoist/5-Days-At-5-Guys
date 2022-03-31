using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class windowButton : MonoBehaviour
{
	
	public void onClick()
	{
		Debug.Log(Global.officeWindow);
		SceneManager.LoadScene("Window");
	}
	
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
