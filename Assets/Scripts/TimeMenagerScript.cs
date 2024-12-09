using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeMenagerScript : MonoBehaviour
{
    [SerializeField] TMP_Text timeDisplay;
    [SerializeField] TMP_Text dayDisplay; 
    [SerializeField] GameObject pauseScreen;
    public float inGameTime;
    public int dayCount;

    public void Start()
    {
        inGameTime = 1160f;
        dayCount = 0;
    }

    public void KeepTime()
    {
        Time.timeScale = 1.0f;
        inGameTime += Time.deltaTime * 2f;

        if (inGameTime >= 1439.0f)
        {
            inGameTime = 0f;
            dayCount++;
        }
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
        dayDisplay.text = "Day " + dayCount.ToString();
    }
}
