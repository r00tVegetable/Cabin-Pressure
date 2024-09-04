using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenager : MonoBehaviour
{
    [SerializeField] GameObject pauseScreen;

    public void Start()
    {
        pauseScreen.SetActive(false);
    }

    public void Update()
    {
        //Pause Screen Control
        if (Input.GetKeyDown(KeyCode.Escape) && pauseScreen.activeInHierarchy == false)
        {
            pauseScreen.SetActive(true);
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && pauseScreen.activeInHierarchy == true)
        {
            pauseScreen.SetActive(false);
        }
    }
}
