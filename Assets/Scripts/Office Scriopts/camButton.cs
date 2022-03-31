using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camButton : MonoBehaviour
{

	public void onClick()
	{
		Debug.Log(Global.officeCameras);
		SceneManager.LoadScene("Cameras");
	}

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
