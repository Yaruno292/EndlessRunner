using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    public GameObject player;
    public GUIText currentScoreText;
    public int currentScore;
	
    void Start()
    {

        currentScore = 0;
    }

	// Update is called once per frame
	void Update () {
        currentScore += 1;
        currentScoreText.text = "" + Mathf.Round(player.transform.position.x);
    }
}
