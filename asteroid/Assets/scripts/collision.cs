using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {

	public bool destroyOrNot;
	public string tagOfTarget;

	public GameObject particles;

	private void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == tagOfTarget){
			Destroy(gameObject);
			if (destroyOrNot){
				GameObject clone;
				clone = Instantiate(particles,col.gameObject.transform.position,new Quaternion (-col.gameObject.transform.rotation.x,-col.gameObject.transform.rotation.y,-col.gameObject.transform.rotation.z,0)); 
				Destroy(col.gameObject);
			}
		}
	}

}
