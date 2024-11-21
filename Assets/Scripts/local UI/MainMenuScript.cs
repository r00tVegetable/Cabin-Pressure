using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenuScript : MonoBehaviour
{
    public GameObject SceneLoadingPanel;

    [SerializeField] AudioSource click;

    [SerializeField] GameObject videoPanel;
    [SerializeField] VideoPlayer introplayer;

    [SerializeField] GameObject backgroundMusic;

    public void Start()
    {
        SceneLoadingPanel.SetActive(false);
        backgroundMusic.SetActive(true);
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
        backgroundMusic.SetActive(false);
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
        yield return new WaitForSecondsRealtime(1f);
        videoPanel.SetActive(true);
        introplayer.Play();
        yield return new WaitForSecondsRealtime(106f);
        SceneManager.LoadScene(1);
    }
}
