using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    int UPspeed = 10;       //how fast the player can ascend

    [SerializeField]
    int speed = 5;          //how fast the player moves forward
	
	void Update () {
        if(Input.GetAxis("Vertical") > 0)   //when the UP_Button is pressed
        {
            goUp();
            this.GetComponent<Rigidbody2D>().gravityScale = 0;      //makes sure the player doesn't get pulled down by gravity
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);       //makes sure that the played doesn't keep it's velocity after moving up
        }
        else
        {
            this.GetComponent<Rigidbody2D>().gravityScale = 1;      //when the button is released, the gravity pulls the played down again
        }

        transform.Translate(speed * Time.deltaTime, 0f, 0f);        //this moves the player forward
    }

    void goUp()
    {
        transform.Translate(0f, Input.GetAxis("Vertical") * UPspeed * Time.deltaTime, 0f);      //accelerates the player up
    }
}
