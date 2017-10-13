using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

    int speed;     //how fast the enemy is

    private void Start()
    {
        speed = Random.Range(5,20);
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(-speed * Time.deltaTime, 0f,0f);        //moves the enemy towards the player
        speed = Random.Range(5,20);
	}
}
