using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
	[SerializeField]
	private TMP_Text curScore;
	[SerializeField]
	private TMP_Text bestScore;
	[SerializeField]
	private Animator animator;

	public void Show()
	{
		curScore.text = GameManager.Data.CurScore.ToString();
		bestScore.text = GameManager.Data.BestScore.ToString();
		animator.SetBool("IsShow", true);
	}
}
