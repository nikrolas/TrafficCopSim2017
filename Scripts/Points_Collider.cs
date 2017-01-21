using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Points_Collider : MonoBehaviour {


    public int score;

    private Rigidbody2D rb2d;


	// Use this for initialization
	void Start () {

        rb2d = GetComponent<Rigidbody2D>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider2D coll) {

        if(coll.CompareTag("")) {
            score += 1;
        }

        if(coll.CompareTag(""))
        {
            Destroy(coll.gameObject);
        }
    }
}
