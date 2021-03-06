﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public GameObject levelBlocker;
    public GameObject fadeOut;
    public AudioSource levelComplete;

    public int timeCalc;
    public int scoreCalc;
    public int totalScored;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;

        timeCalc = GlobalTimer.extendScore * 100;

        timeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.extendScore + "x 100";
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        PlayerPrefs.SetInt("LevelScore", totalScored);

        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelBlocker.SetActive(true);

        //  Takes the objetc out of its parent.
        levelBlocker.transform.parent = null;

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

        yield return new WaitForSeconds(1.75f);
        fadeOut.SetActive(true);

        yield return new WaitForSeconds(1.75f);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
    }
}
