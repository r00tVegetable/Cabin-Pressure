using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameMenager : MonoBehaviour
{
    [SerializeField] GameObject theStatics;
    [SerializeField] GameObject pauseScreen;

    [SerializeField] TMP_Text O2Display;
    [SerializeField] float drainSpeed;
    [SerializeField] bool drainOxygen;  //Change to public when making electrolysis system.
    public float oxygen;

    private void Start()
    {
        oxygen = 100f;
        drainOxygen = false;
        
    }

    public void Update()
    {
        //Oxygen system:
        O2Display.text = $"Oxygen Saturation: {oxygen:0.00}%";
        
        if (drainOxygen == true && pauseScreen.activeInHierarchy == false)
        {
            oxygen -= Time.deltaTime/drainSpeed;
        }
        if(oxygen >75)
        {
            drainSpeed = 40f;
        }
        if(oxygen <= 75)
        {
            drainSpeed = 30f;
        }
        if (oxygen <= 50)
        {
            drainSpeed = 20f;
        }
        if (oxygen <= 25)
        {
            drainSpeed = 10f;
        }
        if(oxygen <= 10)
        {
            drainSpeed = 5f;
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
