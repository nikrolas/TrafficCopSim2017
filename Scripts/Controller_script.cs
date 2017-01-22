using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.W)) {
			BroadcastMessage("CopUp");
			if (Input.GetKey(KeyCode.RightArrow)) {
				BroadcastMessage("DownRight");
			 } 
			if (Input.GetKey(KeyCode.LeftArrow)) {
				BroadcastMessage("DownLeft");
			 } 
			if (Input.GetKey(KeyCode.DownArrow)) {
				BroadcastMessage("Down");
			 } 
		}

		if (Input.GetKey(KeyCode.A)) {
			BroadcastMessage("CopLeft");
			if (Input.GetKey(KeyCode.RightArrow)) {
				BroadcastMessage("RightRight");
			 } 
			if (Input.GetKey(KeyCode.DownArrow)) {
				BroadcastMessage("RightDown");
			 } 
			if (Input.GetKey(KeyCode.UpArrow)) {
				BroadcastMessage("Right");
			 } 
		}

		if (Input.GetKey(KeyCode.S)) {
			BroadcastMessage("CopDown");
			if (Input.GetKey(KeyCode.RightArrow)) {
				BroadcastMessage("UpRight");
			 } 
			if (Input.GetKey(KeyCode.LeftArrow)) {
				BroadcastMessage("UpLeft");
			 } 
			if (Input.GetKey(KeyCode.UpArrow)) {
				BroadcastMessage("Up");
			 } 
		}

		if (Input.GetKey(KeyCode.D)){
			BroadcastMessage("CopRight");

			if (Input.GetKey(KeyCode.UpArrow)) {
				BroadcastMessage("LeftUp");
			 } 
			if (Input.GetKey(KeyCode.LeftArrow)) {
				BroadcastMessage("LeftLeft");
			 } 
			if (Input.GetKey(KeyCode.DownArrow)) {
				BroadcastMessage("Left");
			 } 
		}
	}
}
