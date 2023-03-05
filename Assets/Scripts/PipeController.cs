using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
	[SerializeField]
	private float destoryX;

	private void Update()
	{
		transform.Translate(Vector2.left * GameManager.Data.MoveSpeed * Time.deltaTime);

		if (transform.position.x < destoryX)
			Destroy(gameObject);
	}
}
