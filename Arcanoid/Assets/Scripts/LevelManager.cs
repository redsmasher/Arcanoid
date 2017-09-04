using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
	public void LoadLevel(string name)
	{
		SceneManager.LoadScene(name);
	}

	public void LoadNextLevel()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void BrickCount()
	{
		if (Brick.breakableCount == 0) 
		{
			LoadNextLevel ();
		}
	}
}
