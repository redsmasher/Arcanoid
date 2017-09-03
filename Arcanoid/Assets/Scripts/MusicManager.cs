using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour 
{
	static MusicManager musicManager;
	private AudioSource audioSource = null;

	void Awake () 
	{
		audioSource = GetComponent<AudioSource> ();

		if (musicManager != null) 
		{
			Destroy (gameObject);
		} 
		else 
		{
			musicManager = this;
			GameObject.DontDestroyOnLoad (musicManager);
		}
	}

	void Update () 
	{
		
	}
}
