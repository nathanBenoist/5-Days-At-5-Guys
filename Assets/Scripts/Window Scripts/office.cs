using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class office : MonoBehaviour
{

	public void onClick()
	{
		Debug.Log(Global.windowOffice);
		SceneManager.LoadScene("Office");
	}

    void Start()
    {
		
    }

    void Update()
    {
        
    }
}
