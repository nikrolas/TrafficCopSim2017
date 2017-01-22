using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopManager : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			anim.SetInteger ("State", 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			anim.SetInteger ("State", 1);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			anim.SetInteger ("State", 2);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			anim.SetInteger ("State", 3);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			anim.SetInteger ("State", 4);
		}
	}
}
