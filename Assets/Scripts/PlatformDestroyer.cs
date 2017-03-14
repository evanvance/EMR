using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour {

	public GameObject platDestPoint;

	void Start () {

		platDestPoint = GameObject.Find ("PlatformDestructionPoint");

	}

	void Update () {

		if (transform.position.x < platDestPoint.transform.position.x) {
		
			Destroy (gameObject);

		}

	}
}
