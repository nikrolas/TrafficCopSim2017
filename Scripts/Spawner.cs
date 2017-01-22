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
	public Vector3[] listOfVectors = new Vector3[3];
	public int v;



	// Use this for initialization
	void Start () {
		StartCoroutine(waitSpawner());
		//top car
		listOfVectors[0] = new Vector3(-2.51f, 14.25f, 0);
		//bottom car
		listOfVectors[1] = new Vector3(2.75f, -13.88f, 0);
		//left car
		listOfVectors[2] = new Vector3(-16.67f, -2.89f, 0);
		//right car
		listOfVectors[3] = new Vector3(16.86f, 2.89f, 0);
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator waitSpawner(){ //waits some time before executing below code
		//yield return new WaitForSeconds(startWait);

		while(!stop){
			//Vector3 spawnPosition = new Vector3 ()

//			GameObject CarU = Instantiate (carList, new Vector3(-1.04f, 5.76f, 0), transform.rotation *  Quaternion.Euler(0, 0, 270));
//			CarU.transform.parent = gameObject.transform;
//			GameObject CarD = Instantiate (carList, new Vector3(1.22f, -6.23f, 0), transform.rotation *  Quaternion.Euler(0, 0, 90));
//			CarD.transform.parent = gameObject.transform;
			GameObject CarL = Instantiate (carList, new Vector3(-9.2f, -1.56f, 0), transform.rotation *  Quaternion.Euler(0, 0, 0));
			CarL.transform.parent = gameObject.transform;
//			GameObject CarR =Instantiate (carList, new Vector3(9.33f, 1.17f, 0), transform.rotation *  Quaternion.Euler(0, 0, 180));
//			CarR.transform.parent = gameObject.transform;

			yield return new WaitForSeconds(1);			
		}
	}	
}