using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	private Rigidbody2D rb;
	private PlayerController playerController;
	private Vector3 ballToPaddle;
	private bool hasStarted = false;

	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		playerController = FindObjectOfType<PlayerController> ();
		ballToPaddle = this.transform.position - playerController.transform.position; 
	}

	void Update () 
	{
		if (!hasStarted)
		{
			this.transform.position = playerController.transform.position + ballToPaddle;

			if (Input.GetKeyDown (KeyCode.Mouse0)) 
			{
				hasStarted = true;
				this.rb.velocity = new Vector2 (2f,10f);
			}
		}
	}
}
