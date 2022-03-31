using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraOffice : MonoBehaviour
{

	public void Onclick()
	{
		Debug.Log(Global.cameraOffice);
		SceneManager.LoadScene("Office");
	}

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
