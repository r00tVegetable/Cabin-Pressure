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
    [SerializeField] GameObject twovideoPanel;
    [SerializeField] GameObject threevideoPanel;
    [SerializeField] GameObject transitionpanel;
    [SerializeField] VideoPlayer introplayer;
    [SerializeField] VideoPlayer introtwoPlayer;
    [SerializeField] VideoPlayer introthreePlayer;

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
        yield return new WaitForSecondsRealtime(22.5f);
        twovideoPanel.SetActive(true);
        introtwoPlayer.Play();
        videoPanel.SetActive(false);
        yield return new WaitForSecondsRealtime(13f);
        transitionpanel.SetActive(true);
        twovideoPanel.SetActive(false);
        yield return new WaitForSecondsRealtime(2f);
        threevideoPanel.SetActive(true);
        introthreePlayer.Play();
        transitionpanel.SetActive(false);
        yield return new WaitForSecondsRealtime(71f);
        SceneManager.LoadScene(1);
    }
}
