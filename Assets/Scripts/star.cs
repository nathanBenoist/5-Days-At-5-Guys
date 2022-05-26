using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class star : MonoBehaviour
{
	public AudioSource MenMusic;
    void Start()
    {
        MenMusic.Play();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
		{
			SceneManager.LoadScene("Day1");
		}
    }
}
