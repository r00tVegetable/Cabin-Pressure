using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject SceneLoadingPanel;

    public void Start()
    {
        SceneLoadingPanel.SetActive(false);
    }
    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSaved()
    {
        SceneLoadingPanel.SetActive(true);
    }

    public void CloseSaved()
    {
        SceneLoadingPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
