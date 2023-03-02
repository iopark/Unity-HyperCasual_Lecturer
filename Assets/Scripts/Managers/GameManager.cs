using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public const string DefaultName = "Manager";

	private static GameManager instance;

	public static GameManager Instance { get { return instance; } }

	private void Awake()
	{
		if (instance != null)
		{
			Debug.LogWarning("GameInstance: valid instance already registered.");
			Destroy(this);
			return;
		}

		instance = this;
		DontDestroyOnLoad(this);
		InitManagers();
	}

	private void OnDestroy()
	{
		if (instance == this)
			instance = null;
	}

	private void InitManagers()
	{
		// TODO : 
	}
}
