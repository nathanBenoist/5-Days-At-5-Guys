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
			if(unmyI.dude == true || TheFog.hope == true || TheFog.imDoingFine == true)
			{
				Global.finna2012();
			}
			
			else
			{
				SceneManager.LoadScene("Window");
			}
		}
		
		if(Input.GetKeyDown(KeyCode.C))
		{
			if(unmyI.dude == true || TheFog.hope == true || TheFog.imDoingFine == true)
			{
				Global.finna2012();
			}
			
			else
			{
				SceneManager.LoadScene("Cameras");
			}
		}
		
		if(Input.GetKeyDown(KeyCode.X))
		{
			if(unmyI.dude == true || TheFog.hope == true || TheFog.imDoingFine == true)
			{
				Global.finna2012();
			}
			
			else
			{
				SceneManager.LoadScene("Coffee");
			}
		}
    }
}
