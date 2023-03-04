using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public const string DefaultName = "Manager";

	private static GameManager instance;
	private static DataManager dataManager;

	public static GameManager Instance { get { return instance; } }
	public static DataManager Data { get { return dataManager; } }

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
		GameObject dataObject = new GameObject() { name = "DataManager" };
		dataManager = gameObject.AddComponent<DataManager>();
	}
}
