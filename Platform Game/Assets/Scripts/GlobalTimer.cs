using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay01;
    public GameObject timeDisplay02;

    public bool isTakingTime = false;

    public static int extendScore;
    public int seconds = 150;

    void Update()
    {
        extendScore = seconds;

        if (isTakingTime == false)
        {
            StartCoroutine(SubstractSecond());
        }
    }

    IEnumerator SubstractSecond()
    {
        isTakingTime = true;
        seconds -= 1;

        timeDisplay01.GetComponent<Text>().text = "" + seconds;
        timeDisplay02.GetComponent<Text>().text = "" + seconds;

        yield return new WaitForSeconds(1);

        isTakingTime = false;

    }
}
