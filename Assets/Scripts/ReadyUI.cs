using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ReadyUI : MonoBehaviour
{
	[SerializeField]
	private UnityEvent OnPlayed;

    private void OnPlay(InputValue value)
	{
		OnPlayed?.Invoke();
	}
}
