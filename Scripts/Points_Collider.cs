using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points_Collider : MonoBehaviour {


    public int score;
    public Text scoreText;

    public BoxCollider2D topRoad;
    public BoxCollider2D bottomRoad;
    public BoxCollider2D leftRoad;
    public BoxCollider2D rightRoad;


	void Start ()
    {
        score = 0;
        getScoreText();
	}
	
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider2D coll)
    {
        if (coll.gameObject.name == "temp_car") {
            score += 1;
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
