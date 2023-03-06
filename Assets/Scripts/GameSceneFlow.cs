using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameSceneFlow : MonoBehaviour
{
	private State curState;

	public UnityEvent OnReadyed;
	public UnityEvent OnPlayed;
	public UnityEvent OnGameOvered;

	private void Start()
	{
		ChangeState(State.Ready);
	}

	public void ChangeState(State state)
	{
		curState = state;
		switch (state)
		{
			case State.Ready:
				OnReadyed?.Invoke();
				break;
			case State.Play:
				OnPlayed?.Invoke();
				break;
			case State.GameOver:
				OnGameOvered?.Invoke();
				break;
		}
	}

	public void Play()
	{
		ChangeState(State.Play);
	}

	[Serializable]
	public enum State
	{
		Ready,
		Play,
		GameOver,
	}
}