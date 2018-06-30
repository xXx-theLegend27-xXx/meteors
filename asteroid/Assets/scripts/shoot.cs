using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

	public Rigidbody bulletPrefab;
	public Material mat;
	private float cooldown = 0;
	private timed_delete myDel;

	void Update () {
		if (cooldown > 40){
			mat.color = Color.white;
			if (Input.GetMouseButtonDown(0)){
				cooldown = 0;
				Rigidbody bulletClone;
				bulletClone = Instantiate(bulletPrefab,transform.position,new Quaternion(transform.rotation.x - 90f, transform.rotation.y + 180f,0,0)) as Rigidbody;
				bulletClone.velocity = transform.TransformDirection(Vector3.forward * 20);
				myDel = bulletClone.gameObject.GetComponent<timed_delete>();
				myDel.enabled = true;
			}
		}
		else{
			mat.color = Color.grey;
			cooldown++;
		}
	}
}
