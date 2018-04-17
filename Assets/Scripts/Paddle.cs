using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float MousePosPPU=Input.mousePosition.x/Screen.width*16;
		Vector3 paddlePop=new Vector3(8.0f,this.transform.position.y,this.transform.position.z);
		paddlePop.x=Mathf.Clamp(MousePosPPU,0.5f,15.5f);
		this.transform.position=paddlePop;
	}
}
