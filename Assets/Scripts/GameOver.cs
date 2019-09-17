using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public Text highscore;

    void Start()
    {
        highscore.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
