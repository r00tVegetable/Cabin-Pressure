using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject SceneLoadingPanel;

    [SerializeField] AudioSource click;

    public void Start()
    {
        SceneLoadingPanel.SetActive(false);
    }

    public void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            SceneLoadingPanel.SetActive(false);
        }
    }

    public void StartNewGame()
    {
        click.Play();
        StartCoroutine(countToStart());
    }

    public void LoadSaved()
    {
        click.Play();
        SceneLoadingPanel.SetActive(true);
    }

    public void CloseSaved()
    {
        click.Play();
        SceneLoadingPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator countToStart()
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(1);
    }
}
