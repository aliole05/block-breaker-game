using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {
	public static Music instance=null;
	// Use this for initialization
	void Awake ()
	{
		if (instance != null) {
			GameObject.Destroy (gameObject);
			print ("extra music destroyed");
		}
		else {
			instance=this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}
	

}
