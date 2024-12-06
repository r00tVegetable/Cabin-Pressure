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
    [SerializeField] GameObject skipButton;
    [SerializeField] SubtitleScript subtitleScript;
    [SerializeField] VideoPlayer introplayer;

    [SerializeField] GameObject backgroundMusic;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        SceneLoadingPanel.SetActive(false);
        skipButton.SetActive(false);
        backgroundMusic.SetActive(true);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && SceneLoadingPanel.activeInHierarchy == true)
        {
            SceneLoadingPanel.SetActive(false);
        }
        if(Input.anyKey && videoPanel.activeInHierarchy == true)
        {
            Cursor.visible = true;
            StartCoroutine(SkipButton());
        }
    }

    public void StartNewGame()
    {
        click.Play();
        backgroundMusic.SetActive(false);
        Cursor.visible = false;
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

    public void SkipIntro()
    {
        SceneManager.LoadScene(1);
    }

    IEnumerator countToStart()
    {
        yield return new WaitForSecondsRealtime(1f);
        videoPanel.SetActive(true);
        introplayer.Play();
        subtitleScript.IntroSequance();
        yield return new WaitForSecondsRealtime(106f);
        SceneManager.LoadScene(1);
    }

    IEnumerator SkipButton()
    {
        skipButton.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        skipButton.SetActive(false);
        Cursor.visible = false;
    }
}
