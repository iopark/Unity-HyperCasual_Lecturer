using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
	[SerializeField]
	private Transform spawnPoint;
	[SerializeField]
	private PipeController pipePrefab;
	[SerializeField]
	private float repeatTime;
	[SerializeField]
	private float randomRange;

	private Coroutine routine;

	private void OnEnable()
	{
		routine = StartCoroutine(SpawnRoutine());
	}

	private void OnDisable()
	{
		StopCoroutine(routine);
	}

	IEnumerator SpawnRoutine()
	{
		while (true)
		{
			yield return new WaitForSeconds(repeatTime);
			Vector2 spawnPos = spawnPoint.position + Vector3.up * Random.Range(-randomRange, randomRange);
			Instantiate(pipePrefab, spawnPos, Quaternion.identity);
		}
	}
}
