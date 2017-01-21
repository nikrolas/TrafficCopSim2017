using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject carList;
	public Vector3 spawnValues;
	public float spawnLate;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;
	public bool stop;



	// Use this for initialization
	void Start () {
		StartCoroutine(waitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
		//constantly makes random time
		//spawnWait = 1;
	}

	IEnumerator waitSpawner(){ //waits some time before executing below code
		yield return new WaitForSeconds(startWait);
		
		while(!stop){
			//Vector3 spawnPosition = new Vector3 ()
			Instantiate (carList, transform.TransformPoint(0,0,0), gameObject.transform.rotation);
			yield return new WaitForSeconds(1);			
		}
	}	
}
