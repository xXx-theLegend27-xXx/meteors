using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontFall : MonoBehaviour {
	void Update () {
		if (transform.position.y < -200){
			Destroy(gameObject);
		}
	}
}