using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
	public LevelManager levelManager;

	void OnTriggerEnter2D()
	{
		levelManager.LoadLevel ("WinScreen");
	}
}
