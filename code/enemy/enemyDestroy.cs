using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDestroy : MonoBehaviour {

    //this is a basic timer system
    int timerDead = 0;
	
	void Update () {
        timerDead += 1;

        if (timerDead >= 400)
        {
            Destroy(gameObject);    //destroys the object this script is tied to
        }
    }
}
