using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidInstantiate : MonoBehaviour {

	public float level = 10f;
	public float startHowMuch = 5f;
	public float length = 50f;

	public float cooldown;
	public int current;

	void Start(){
		cooldown = level * 5f;
		current = 0;
	}

	public GameObject asteroid;
	
	public void Update(){

		current++;

		Vector3 v3Inst = new Vector3(
			Random.Range(-10,10),
			20,
			Random.Range(startHowMuch, startHowMuch+length));

		if (current >= cooldown){
			if (transform.position.z + 50 > startHowMuch){
				GameObject clone;
				clone = Instantiate(asteroid,v3Inst,new Quaternion(Random.Range(-180f,180f),Random.Range(-180f,180f),Random.Range(-180f,180f),0f));
				float scale = Random.Range(0.4f,2.5f);
				clone.transform.localScale = new Vector3 (scale,scale,scale);
				clone.GetComponent<Rigidbody>().useGravity = true;
				current = 0;
			}
		}
	}
}