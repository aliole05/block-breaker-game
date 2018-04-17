using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {
	private levelmanager lm;

	//Use this for initialization
	void OnTriggerEnter2D (Collider2D trigger)
	{
	lm=GameObject.FindObjectOfType<levelmanager>();
	lm.LoadLevel("Lose");
	}
	void OnCollisionEnter2D (Collision2D collision)
	{
	print ("collision");
	}
}
