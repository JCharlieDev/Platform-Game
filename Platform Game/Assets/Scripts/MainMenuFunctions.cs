﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunctions : MonoBehaviour
{
    public AudioSource buttonPress;

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
}
