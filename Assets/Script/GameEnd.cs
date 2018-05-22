using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Invoke("RestartGame", 3f);
	}

    public void RestartGame()
    {
        SceneManager.LoadScene("GameStart", LoadSceneMode.Single);
        Debug.Log(2);
    }
}
