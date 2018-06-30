using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

	public Text text1,text2,text3,text4,end;
	private int timer = 0;
	
	private void Update() {
		timer++;

		if (timer < 150 ){
			text1.gameObject.SetActive(true);
			text2.gameObject.SetActive(false);
			text3.gameObject.SetActive(false);
			text4.gameObject.SetActive(false);
		} 
		else if (timer < 300 ){
			text1.gameObject.SetActive(true);
			text2.gameObject.SetActive(true);
			text3.gameObject.SetActive(false);
			text4.gameObject.SetActive(false);
		} 
		else if (timer < 450 ){
			text1.gameObject.SetActive(true);
			text2.gameObject.SetActive(true);
			text3.gameObject.SetActive(true);
			text4.gameObject.SetActive(false);
		} 
		else{
			text1.gameObject.SetActive(true);
			text2.gameObject.SetActive(true);
			text3.gameObject.SetActive(true);
			text4.gameObject.SetActive(true);
			end.gameObject.SetActive(true);
			if (Input.GetKeyDown("space")){
				Application.LoadLevel("levelOne");
			}
		} 


	}

}
