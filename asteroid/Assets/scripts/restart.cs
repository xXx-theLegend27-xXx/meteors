using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class restart : MonoBehaviour {

	public void restartf(string sceneName){
		Application.LoadLevel(sceneName);
	}

}
