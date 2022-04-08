using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OffKeyB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {			
		if(Input.GetKeyDown(KeyCode.F))
		{
			SceneManager.LoadScene("Window");
		}
		
		if(Input.GetKeyDown(KeyCode.C))
		{
			SceneManager.LoadScene("Cameras");
		}
		
		if(Input.GetKeyDown(KeyCode.X))
		{
			SceneManager.LoadScene("Coffee");
		}
    }
}
