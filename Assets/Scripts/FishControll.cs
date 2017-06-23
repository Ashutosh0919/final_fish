using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class FishControll : MonoBehaviour
{
	private bool FacingRight;	
	private Vector3 MovingDirection = Vector3.left ;
	public ParticleSystem Particle;
	public AudioClip beep;
	public AudioSource mySource;



 	void Start()
	  {
		
    	}

	void Update ()//move one point to ather point
	{
		gameObject.transform.Translate (MovingDirection * Time.smoothDeltaTime);

		if (gameObject.transform.position.x > 18) 
	    	{
		    	MovingDirection = Vector3.left;
			    Flip ();
		    } 
		else if (gameObject.transform.position.x <-4)
		    {
			   MovingDirection = Vector3.right;
		    	Flip ();
		     }

		onMouseDown ();
	 }

	protected void Flip() //flip the fish   
	  {
	    	FacingRight = !FacingRight;

		    Vector3 theScale = transform.localScale;
		    theScale.x *= -1;
		    transform.localScale = theScale;
	 }

	void onMouseDown ()
	{ 
		
		if (Input.GetMouseButtonDown (0)) {


			SpriteRenderer sdr = (SpriteRenderer)(gameObject.GetComponents<SpriteRenderer> ().GetValue (0));
			Vector3 v3 = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 v2 = new Vector2 (v3.x, v3.y);

		

			if (sdr.bounds.Contains (v2))
			{
				mySource.clip = beep;
				mySource.Play();

				Destroy (this.gameObject);//destroy the object
			} 

		
		
		}
	}


		
			 
}
	

  

	






