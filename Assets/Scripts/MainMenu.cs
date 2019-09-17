using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Text highscore;

    void Start()
    {
        highscore.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Play();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }

    public void Play()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void Reset()
    {
        PlayerPrefs.SetInt("highscore", 0);
        highscore.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
    }
}
