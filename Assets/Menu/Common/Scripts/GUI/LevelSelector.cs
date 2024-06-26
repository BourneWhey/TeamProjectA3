﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using MoreMountains.Tools;

namespace MoreMountains.InfiniteRunnerEngine
{	
	/// <summary>
	/// Add this component to a button so it can be used to go to a level, or restart the current one
	/// </summary>
	public class LevelSelector : MonoBehaviour
	{
	    public string LevelName;

		/// <summary>
		/// Asks the LevelManager to go to a specified level
		/// </summary>
	    public virtual void GoToLevel()
	    {
	        SceneManager.LoadScene(0);
	    }

		/// <summary>
		/// Restarts the current level.
		/// </summary>
	    public virtual void RestartLevel()
	    {
	      	//GameManager.Instance.UnPause();
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	    }

	    /// <summary>
	    /// Resumes the game
	    /// </summary>
	    public virtual void Resume()
	    {
	        GameManager.Instance.UnPause();
	    }

	    /// <summary>
	    /// Resets the score.
	    /// </summary>
	    public virtual void ResetScore()
	    {
	    	SingleHighScoreManager.ResetHighScore();
	    }
	}
}
