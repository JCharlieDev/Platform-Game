using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollCredits : MonoBehaviour
{
    public GameObject creditsRoll;

    void Start()
    {
        StartCoroutine(RollCreds());
    }

    IEnumerator RollCreds()
    {
        yield return new WaitForSeconds(0.5f);
        creditsRoll.SetActive(true);

        yield return new WaitForSeconds(15f);
        SceneManager.LoadScene(1);
    }
}
