using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
	

public class RandomFish : MonoBehaviour
{
	public GameObject fishPrefab;

	public static int numFish=10;
	public static GameObject[] allFish = new GameObject[numFish];
	public static int tankSize = 5;
	public static Vector3 goalpos = Vector3.zero;
	public static GameObject[] indices = new GameObject[20];
	int num=0;

	// Use this for initialization
	IEnumerator Start () 
	{
		
		for (int i = 0; i < numFish; i++) 
		{

				Vector2 pos = new Vector2(Random.Range (-tankSize, tankSize), 
					             Random.Range (-tankSize, tankSize));
			yield return new WaitForSeconds(2);

			allFish [i] = (GameObject)Instantiate(fishPrefab ,pos, Quaternion.identity);

			indices [num++] = allFish [i];
			   
		}
		for (int i = 0; i < numFish; i++)
		{
			yield return new WaitForSeconds(2);

			Destroy (indices [i].gameObject);
			numFish--;
		}
	


	}

	// Update is called once per frame
	void Update () 
	{
		



		if (Random.Range (5,100 ) < 25) 
		{
			goalpos= new Vector3 (Random.Range (-tankSize, tankSize), 
				                   Random.Range (-tankSize, tankSize));
			
		}


  }
}








