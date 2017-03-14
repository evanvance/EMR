using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public PlayerController thePlayer;

	private Vector3 lastPlayerPos;
	private float distanceToMove;

	void Start () {

		thePlayer = FindObjectOfType<PlayerController>();
		lastPlayerPos = thePlayer.transform.position;

	}

	void Update () {

		distanceToMove = thePlayer.transform.position.x - lastPlayerPos.x;

		transform.position = new Vector3 (transform.position.x + distanceToMove, transform.position.y, transform.position.z);

		lastPlayerPos = thePlayer.transform.position;
	}
}
