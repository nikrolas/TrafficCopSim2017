using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points_Collider : MonoBehaviour {


    public int score;
    public Text scoreText;

	void Start ()
    {
        score = 0;
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
