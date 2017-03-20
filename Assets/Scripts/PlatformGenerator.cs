using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	public GameObject thePlatform;
	public Transform GenerationPoint;
	public float distBetween;

	private float platWidth;

	public float distBetweenMin;
	public float distBetweenMax;

	public ObjectPooler theObjPool;

	void Start () {

		platWidth = thePlatform.GetComponent<BoxCollider2D> ().size.x;

	}

	void Update () {

		if (transform.position.x < GenerationPoint.position.x) {
		
			distBetween = Random.Range (distBetweenMin, distBetweenMax);
			transform.position = new Vector3 (transform.position.x + platWidth + distBetween, transform.position.y, transform.position.z);

			//Instantiate (thePlatform, transform.position, transform.rotation);

			GameObject newPlat = theObjPool.getPooledObj ();

			newPlat.transform.position = transform.position;
			newPlat.transform.rotation = transform.rotation;
			newPlat.SetActive (true);

		}

	}
}
