using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour {

	
	void Update () {
		if (transform.position.z > 505){
			Application.LoadLevel("winAndLevelSelect");
		}
	}

}
