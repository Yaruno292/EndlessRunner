using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayGame : MonoBehaviour {

	public void LoadGame()
    {
        SceneManager.LoadScene("Endless_runner");    //starts the game
    }
}
