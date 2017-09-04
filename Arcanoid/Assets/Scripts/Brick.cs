using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour 
{
	public int maxHits;
	public Sprite[] sprites;

	private int currentHit;

	void OnCollisionEnter2D(Collision2D col)
	{
		currentHit++;
		if (currentHit >= maxHits) 
		{
			Destroy (gameObject);
		} 
		else 
		{
			LoadSprites ();
		}
	}

	void LoadSprites()
	{
		int spriteIndex = currentHit - 1;
		this.GetComponent<SpriteRenderer> ().sprite = sprites [spriteIndex];
	}
}
