using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour 
{
	public int maxHits;

	private int currentHit;

	void OnCollisionEnter2D(Collision2D col)
	{
		currentHit++;
		if (currentHit >= maxHits) 
		{
			Destroy (gameObject);
		}
	}

	void Update ()
	{
		
	}
}
