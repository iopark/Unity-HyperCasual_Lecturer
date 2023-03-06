using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
	[SerializeField]
	private float jumpSpeed;

	[SerializeField]
	private LayerMask ObstacleLayer;
	[SerializeField]
	private UnityEvent OnDied;

	private new Rigidbody2D rigidbody;
	private Animator animator;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}

	private void Update()
	{
		Rotate();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if ((1 << collision.gameObject.layer & ObstacleLayer) != 0)
			OnDied?.Invoke();
	}

	private void OnJump(InputValue value)
	{
		Jump();
	}	

	private void Jump()
	{
		// rigidbody.AddForce(Vector2.up * jumpPower, ForceMode.Impulse);
		rigidbody.velocity = Vector2.up * jumpSpeed;
	}

	private void Rotate()
	{
		transform.right = rigidbody.velocity + Vector2.right * GameManager.Data.MoveSpeed;
	}
}
