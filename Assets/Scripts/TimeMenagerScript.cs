using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeMenagerScript : MonoBehaviour
{
    [SerializeField] TMP_Text timeDisplay;
    [SerializeField] GameObject pauseScreen;
    public float inGameTime;

    public void KeepTime()
    {
        Time.timeScale = 1.0f;
        inGameTime += Time.deltaTime * 5f;
    }

    public void Update()
    {
        if(pauseScreen.gameObject.activeInHierarchy == false)
        {
            KeepTime();
        }

        int minutes = Mathf.FloorToInt(inGameTime / 60f);
        int seconds = Mathf.FloorToInt(inGameTime - minutes * 60f);

        timeDisplay.text = string.Format("{0:0}:{1:00}", minutes, seconds) + " S.S.T.";
    }
}
