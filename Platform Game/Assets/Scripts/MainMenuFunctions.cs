using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunctions : MonoBehaviour
{
    public AudioSource buttonPress;
    public GameObject bestScoreDisplay;

    public int bestScore;

    void Start()
    {
        Cursor.visible = true;

        bestScore = PlayerPrefs.GetInt("LevelScore");

        bestScoreDisplay.GetComponent<Text>().text = "Best: " + bestScore;
    }

    public void PlayGame()
    {
        buttonPress.Play();

        RedirectToLevel.redirectToLevel = 3;

        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayCreds()
    {
        buttonPress.Play();
        SceneManager.LoadScene(4);
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("LevelScore", 0);
        //  If multiple PlayerPrefs.
        //  PlayerPrefs.SetInt("LevelScore5", 0);

        //  Resets instantly.
        bestScoreDisplay.GetComponent<Text>().text = "Best: " + bestScore;

    }
}
