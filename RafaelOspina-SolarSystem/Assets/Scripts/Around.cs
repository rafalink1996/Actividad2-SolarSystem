using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Around : MonoBehaviour {

	public float translationSpeed;
	//public float fixedDistance;
	public Transform sunPivot;

	/*void Update () {
		this.transform.position = (transform.position - sunPivot.transform.position).normalized * fixedDistance + sunPivot.transform.position;
	}*/

	void LateUpdate() {
		this.transform.RotateAround (sunPivot.position, Vector3.up, -translationSpeed);
	}
}