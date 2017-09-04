using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	private float mousePosInBlocks;

	void Start () 
	{
		
	}

	void Update () 
	{
		Vector3 paddlePos = new Vector3 (this.transform.position.x, this.transform.position.y, 0f);
		mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp(mousePosInBlocks,0f,9.80f);
		this.transform.position = paddlePos;
	}
}
