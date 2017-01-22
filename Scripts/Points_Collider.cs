using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points_Collider : MonoBehaviour {


    public static int score = 0;
    public Text scoreText;

	void Start ()
    {
        getScoreText();
	}
	
	void Update ()
    {
		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "temp_car(Clone)") {
            score++;
            getScoreText();
            coll.gameObject.SetActive(false);
            Destroy(coll.gameObject);
        }
    }

    void getScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
