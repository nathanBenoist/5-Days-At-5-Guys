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
			if(Bazos.notAsRichAsElon == true)
			{
				Global.finna2012();
			}
			
			SceneManager.LoadScene("Office");
		}
    }
}
