using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	public Material m_Material;

	public Vector3 pos;

	private float frontAcceleration = 3f;
	private float frontSpeed = 0;
	private float maxFrontSpeed = 16f;

	void Update () {

		float ad = Input.GetAxis("ad") * 10;
		float ws = Input.GetAxis("ws");

		frontSpeed += frontAcceleration * ws * Time.deltaTime;

		frontSpeed = Mathf.Clamp(frontSpeed, -maxFrontSpeed, maxFrontSpeed);

		if(ws == 0){
			if (frontSpeed > 0){
				frontSpeed -= 4f * Time.deltaTime;
			}
			else if (frontSpeed < 0){
				frontSpeed += 4f * Time.deltaTime;
			}
		}

		transform.Translate(0,0,frontSpeed * Time.deltaTime);
		transform.Translate(ad * Time.deltaTime,0,0);


	if (ws > 0){
		m_Material.color = Color.green;
	}
	else if(ws < 0){
		m_Material.color = Color.red;
	}
	else{
		m_Material.color = Color.black;
	}

	pos = transform.position;

	if(pos.x > 10){
		pos.x = 10;
	}
	if(pos.x < -10){
		pos.x = -10;
	}
	if(pos.y > 20){
		pos.y = 20;
	}
	if(pos.y < -30){
		pos.y = -30;
	}
	if(pos.z < 0){
		pos.z = 0;
	}

	transform.position = pos;
	}
}
