using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpForce;

	private Rigidbody2D myRigidBody;

	public bool onGround;
	public LayerMask whichIsGround;

	private Collider2D myCollider;

	private Animator myAnimator;

	void Start () {

		myRigidBody = GetComponent<Rigidbody2D> ();
		myCollider = GetComponent<Collider2D> ();
		myAnimator = GetComponent<Animator> ();

	}

	void Update () {

		onGround = Physics2D.IsTouchingLayers (myCollider, whichIsGround);

		myRigidBody.velocity = new Vector2 (moveSpeed, myRigidBody.velocity.y);

		if (Input.GetKeyDown (KeyCode.Space) && onGround) {
			myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, jumpForce);
		}

		myAnimator.SetFloat ("Speed", myRigidBody.velocity.x);
		myAnimator.SetBool ("onGround", onGround);

	}
}
