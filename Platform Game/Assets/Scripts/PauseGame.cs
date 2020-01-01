using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseMenul;
    public AudioSource levelMusic;
    public AudioSource pauseJingle;
    public bool isPaused = false;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (isPaused == false)
            {
                Cursor.visible = true;
                isPaused = true;

                Time.timeScale = 0;

                pauseJingle.Play();
                levelMusic.Pause();
                pauseMenul.SetActive(true);
            }
            else
            {
                ResumeGameplay();
            }
        }
    }

    public void ResumeGame()
    {
        ResumeGameplay();
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
        ResumeGameplay();
    }
    public void QuitToMenu()
    {
        SceneManager.LoadScene(1);
        ResumeGame();
    }

    private void ResumeGameplay()
    {
        Cursor.visible = false;
        isPaused = false;

        Time.timeScale = 1;

        levelMusic.UnPause();
        pauseMenul.SetActive(false);
    }
}
