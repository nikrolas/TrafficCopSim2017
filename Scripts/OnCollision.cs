using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "singleBottomCar"){
			Destroy(col.gameObject);
		}
	}
}
