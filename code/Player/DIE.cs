using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIE : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animationPlayer.ded = true;
    }
}
