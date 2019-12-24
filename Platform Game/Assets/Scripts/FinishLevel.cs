using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public AudioSource levelComplete;

    void OnTriggerEnter()
    {
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);

        levelComplete.Play();

        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);

        yield return new WaitForSeconds(.75f);
        theScore.SetActive(true);

        yield return new WaitForSeconds(0.75f);
        totalScore.SetActive(true);

        yield return new WaitForSeconds(0.75f);
    }
}
