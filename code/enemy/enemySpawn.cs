using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour {

    public GameObject enemy;

    //this is a basic timer system to count when to spawn a new enemy
    int randomTimer;

    private void Start()
    {
        randomTimer = Random.Range(100, 250);
    }

    // Update is called once per frame
    void Update () {
        randomTimer -= 1;

        if (randomTimer == 0)
        {
            Instantiate(enemy, transform.position, gameObject.transform.rotation);  //spawns a new enemy
            randomTimer = Random.Range(50,300);
        }
	}
}
