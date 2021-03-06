using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {

	public GameObject pooledObj;

	public int pooledAmt;

	List<GameObject> pooledObjs;

	void Start () {

		pooledObjs = new List<GameObject>();

		for (int i = 0; i < pooledAmt; i++) {
			GameObject obj = (GameObject)Instantiate (pooledObj);
			obj.SetActive (false);
			pooledObjs.Add (obj);
		}
	}

	public GameObject getPooledObj() {
	
		for (int i = 0; i < pooledObjs.Count; i++) {
			if (!pooledObjs [i].activeInHierarchy) {
				return pooledObjs [i];
			}
		}

		GameObject obj = (GameObject)Instantiate (pooledObj);
		obj.SetActive (false);
		pooledObjs.Add (obj);
		return obj;
	}
}
