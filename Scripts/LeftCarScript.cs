using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCarScript : MonoBehaviour
{
    public int movementSpeed;
    public float rotatespeed = 1.0f;
    public enum startingPoint { Left, Right, Up, Down };
    public string[] directionMovement = { "Left", "Right", "Straight" };
    public string movement;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        movementSpeed = 0;
    }

    // Use this for initialization
    void Start()
    {
        System.Random random = new System.Random();
        this.movement = directionMovement[random.Next(directionMovement.Length)];
        movementSpeed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //use one spawner, make 4 cars spawn from their locations
        //rotate based on direction
        if (this.movement == "Left")
        {
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
            transform.Rotate(0, 0, 0.5f);
        }
        else if (this.movement == "Right")
        {
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
            transform.Rotate(0, 0, -0.5f);
        }
        else
        {
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        }

        //transform.position += transform.right * Time.deltaTime * movementSpeed;
    }
}