using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioManager.Instance.PlayBegin();
            Invoke("StartGame", 2f);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitGame();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }

    public void EndGame()
    {
        SceneManager.LoadScene("GameEnd", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
