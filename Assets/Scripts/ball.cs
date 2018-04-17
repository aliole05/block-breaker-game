using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
	private Paddle paddle;
	private bool hasStarted=false;
	private Vector3 BalltoPaddle;
	// Use this for initialization
	void Start () {
	    paddle=GameObject.FindObjectOfType<Paddle>();
		BalltoPaddle=this.transform.position-paddle.transform.position;


	}
	
	// Update is called once per frame
	void Update () {
		if(hasStarted==false)
		{this.transform.position=paddle.transform.position + BalltoPaddle;
		if(Input.GetMouseButtonDown(0)){
		hasStarted=true;
		this.GetComponent<Rigidbody2D>().velocity=new Vector2(4f,6f);

			}
		}
	}
	//this was not playing sound when the brick was being destroyed
	//void OnCollisionEnter2D (Collision2D collision)
	//{ if(hasStarted)
	  //  this.GetComponent<AudioSource>().Play();
	//}
	void OnCollisionEnter2D (Collision2D collider)
	{
		Vector2 tweak = new Vector2 (Random.Range (0f, 0.3f), Random.Range (0f, 0.3f));
	
		if (hasStarted) {
			this.GetComponent<Rigidbody2D>().velocity+=tweak;
		}


	}

}