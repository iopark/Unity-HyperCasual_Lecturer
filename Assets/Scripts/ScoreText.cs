using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
	private TMP_Text text;

	private void Awake()
	{
		text = GetComponent<TMP_Text>();
	}

	private void OnEnable()
	{
		GameManager.Data.OnCurScoreChanged += SetScore;
	}

	private void OnDisable()
	{
		GameManager.Data.OnCurScoreChanged -= SetScore;
	}

	private void SetScore(int score)
	{
		text.text = score.ToString();
	}
}
