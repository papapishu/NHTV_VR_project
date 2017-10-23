using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {
	public GameObject target;
	public float offset;
	public float capsuleCenter;

	void Start () {
	}

	void Update(){
		capsuleCenter = target.GetComponent<CapsuleCollider> ().center.y;


		//gameObject.transform.position = new Vector3(target.transform.position.x, (capsuleCenter/2) - offset, target.transform.position.z);
	}
}
