using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject fadeOut;
    public GameObject levelAudio;

    void OnTriggerEnter()
    {
        StartCoroutine(GameOverText());
    }

    IEnumerator GameOverText()
    {
        gameOver.SetActive(true);
        fadeOut.SetActive(true);
        levelAudio.SetActive(false);

        yield return new WaitForSeconds(3);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);

    }
}
