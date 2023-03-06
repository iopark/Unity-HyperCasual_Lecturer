using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
	private float moveSpeed = 3;
	public float MoveSpeed { get { return moveSpeed; } set { moveSpeed = value; } }

	private int bestScore;
	public int BestScore { get { return bestScore; } set { bestScore = value; OnBestScoreChanged?.Invoke(bestScore); } }
	public event UnityAction<int> OnBestScoreChanged;

	private int curScore;
	public int CurScore
	{
		get { return curScore; }
		set
		{
			curScore = value;
			OnCurScoreChanged?.Invoke(curScore);
			if (curScore > BestScore)
				BestScore = curScore;
		}
	}
	public event UnityAction<int> OnCurScoreChanged;
}
