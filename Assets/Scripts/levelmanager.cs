using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanager : MonoBehaviour {

	public void LoadLevel (string name)
	{Application.LoadLevel(name);
	}
	public  void Quit ()
	{Application.Quit();
	}
	public void LoadNextLevel ()
	{
	Application.LoadLevel(Application.loadedLevel +1);
	}
	public void BreakCount ()
	{
		if (Hit.breakCount <= 0) {
		LoadNextLevel();
		}
	}
}
