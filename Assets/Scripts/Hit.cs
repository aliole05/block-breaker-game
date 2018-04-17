using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
	private int MaxHit;
	private int HitCount; 
	public Sprite[] hitSprite;
	public AudioClip crack;
	public static int breakCount = 0;
	private bool isBreakable;
	private levelmanager lm;
	public GameObject smoke;
	// Use this for initialization
	void Start ()
	{
		HitCount = 0;
		isBreakable = (this.tag == "Breakable");
		if (isBreakable) {
			breakCount++;
			print(breakCount);
		}

		lm=GameObject.FindObjectOfType<levelmanager>();

	}
	

	void OnCollisionEnter2D (Collision2D collider)
	{	
		AudioSource.PlayClipAtPoint(crack,transform.position);
		if(isBreakable)
		 HandleHits();

	}

	void HandleHits ()
	{
		HitCount++;
		MaxHit = hitSprite.Length + 1;
		if (HitCount >= MaxHit) {
			breakCount--;
			GameObject smokepuff=Instantiate(smoke,gameObject.transform.position,Quaternion.identity) as GameObject;
			smokepuff.GetComponent<ParticleSystemRenderer>().material.SetColor("_EmissionColor",
															gameObject.GetComponent<SpriteRenderer>().color);
			GameObject.Destroy(gameObject);
			lm.BreakCount();
		}

	 	else
			{ if(hitSprite[HitCount-1])
				this.GetComponent<SpriteRenderer>().sprite=hitSprite[HitCount-1];
			}
	}



}
