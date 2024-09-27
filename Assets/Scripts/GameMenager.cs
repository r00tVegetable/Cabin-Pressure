using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameMenager : MonoBehaviour
{
    [SerializeField] GameObject theStatics;
    [SerializeField] GameObject pauseScreen;

    [SerializeField] bool drainOxygen;
    [SerializeField] TMP_Text O2Display;
    public float oxygen;

    private void Start()
    {
        oxygen = 100f;
        drainOxygen = false;
    }

    public void Update()
    {
        O2Display.text = $"Oxygen Saturation: {oxygen:0.00}%";

        if (drainOxygen == true && pauseScreen.activeInHierarchy == false)
        {
            oxygen -= Time.deltaTime;
        }

        if (oxygen <= 0)
        {
            KillMe();
        }

    }

    public void KillMe()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(6);
        Destroy(theStatics);
    }
}
