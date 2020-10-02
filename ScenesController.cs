using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
	public string EnterScene;
	public string EscScene;
	public bool isEscForQuit = false;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.Return))
		{
			Debug.Log ("Name Scene : " + EnterScene);
			SceneManager.LoadScene (EnterScene);
		}

		if (Input.GetKeyUp (KeyCode.Escape))
		{
			if (isEscForQuit)
			{
				Application.Quit ();
			}
			else
			{
				Debug.Log ("Name Scene : " + EscScene);
				SceneManager.LoadScene (EscScene);
			}
		}
	}
}
