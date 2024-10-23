using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenager : MonoBehaviour
{
    [SerializeField] GameObject pauseScreen;
    [SerializeField] GameObject statics;

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

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
        pauseScreen.SetActive(false);
        Destroy(statics);
    }
}
