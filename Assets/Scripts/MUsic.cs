using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUsic :MonoBehaviour
{
	public AudioClip beep;
	public AudioSource mySource;

	// Use this for initialization
	void Start ()
	{
		

	}
	
	// Update is called once per frame




		void onMouseDown ()
		{ 

			if (Input.GetMouseButtonDown (0)) 
			{


				SpriteRenderer sdr = (SpriteRenderer)(gameObject.GetComponents<SpriteRenderer> ().GetValue (0));
				Vector3 v3 = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				Vector2 v2 = new Vector2 (v3.x, v3.y);
				mySource.clip = beep;
				mySource.Play();

	         }
	   	
			  }
	}
