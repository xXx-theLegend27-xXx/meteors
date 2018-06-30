using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour {

	public Transform target;
	public Vector3 offset;

	void Update () {
		transform.position = target.position;
		transform.Translate(offset);
	}
}
