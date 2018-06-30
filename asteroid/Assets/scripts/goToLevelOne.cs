using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToLevelOne : MonoBehaviour {

	public void goTof(string sceneName){
		Application.LoadLevel(sceneName);
	}

}
