using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_Collider : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D trigger) {
		print("Scene Trigger");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
