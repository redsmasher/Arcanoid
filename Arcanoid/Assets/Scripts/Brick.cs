using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour 
{
	public Sprite[] sprites;
	public static int breakableCount = 0;
	public LevelManager levelManager;

	private int currentHit;
	private bool isBreakable;

	void Start()
	{
		isBreakable = this.tag == "Breakable";
		if (isBreakable) 
		{
			breakableCount++;
		}
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (isBreakable) 
		{
			HandleHits ();
		}
	}

	void HandleHits()
	{
		currentHit++;
		int maxHits = sprites.Length + 1;
		if (currentHit >= maxHits) 
		{
			breakableCount--;
			levelManager.BrickCount ();
			Destroy (gameObject);
		} 
		else 
		{
			LoadSprites ();
			levelManager.BrickCount ();
		}
	}

	void LoadSprites()
	{
		int spriteIndex = currentHit - 1;
		this.GetComponent<SpriteRenderer> ().sprite = sprites [spriteIndex];
	}
}
