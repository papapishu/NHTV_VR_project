using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour {

	public GameObject spawnPoint;

	
	void Update () {
		if (gameObject.transform.position.y < -10) {
			transform.position = spawnPoint.transform.position;
		}
	}
}
