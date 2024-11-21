using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenager : MonoBehaviour
{
    [SerializeField] GameObject pauseScreen;

    [SerializeField] TMP_Text O2Display;
    [SerializeField] float drainBuffer;
    [SerializeField] bool drainOxygen;
    [SerializeField] bool solarPanels;
    [SerializeField] bool stationPower;
    [SerializeField] Image powerLevel;

    public float oxygen;
    public float electricity;

    private void Start()
    {
        oxygen = 100f;
        drainOxygen = false;
        electricity = 100f;
        solarPanels = true;
    }

    public void Update()
    {
        //Oxygen system:
        O2Display.text = $"Oxygen Saturation: {oxygen:0.00}%";

        if (drainOxygen == true && pauseScreen.activeInHierarchy == false)
        {
            oxygen -= Time.deltaTime / drainBuffer;
        }
        if (oxygen > 75)
        {
            drainBuffer = 30f;
        }
        if (oxygen <= 75)
        {
            drainBuffer = 20f;
        }
        if (oxygen <= 50)
        {
            drainBuffer = 10f;
        }
        if (oxygen <= 25)
        {
            drainBuffer = 5f;
        }
        if (oxygen <= 10)
        {
            drainBuffer = 1f;
        }
        if (oxygen <= 0)
        {
            KillMe();
        }

        //Electrisity System:
        powerLevel.fillAmount = electricity / 100;
        if (solarPanels == true && pauseScreen.activeInHierarchy == false)
        {
            electricity += Time.deltaTime;
        }
        if (solarPanels == false && pauseScreen.activeInHierarchy == false)
        {
            electricity -= Time.deltaTime;
        }
        if (electricity > 100)
        {
            electricity = 100;
        }
        if (electricity > 0)
        {
            stationPower = true;
        }
        if (electricity <= 0)
        {
            electricity = 0;
            stationPower = false;
        }
    }

    public void KillMe()
    {
        Time.timeScale = 0;
        //save final score here.
        SceneManager.LoadScene(2);
    }
}
