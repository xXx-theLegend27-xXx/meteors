using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotate : MonoBehaviour {

	public Transform camTransform;

	void Update () {
		float mouseX = Input.GetAxis("Mouse X") * 5;
		float mouseY = Input.GetAxis("Mouse Y") * 5;
		
		if (Input.GetKey(KeyCode.Mouse1)){
			transform.Rotate(0,0,mouseX);	
			camTransform.Rotate(0,0,mouseX);
			transform.Rotate(mouseY,0,0);
			camTransform.Rotate(mouseY,0,0);
		}
	}
}
