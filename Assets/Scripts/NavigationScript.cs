using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NavigationScript : MonoBehaviour
{
    public List<GameObject> buttons = new List<GameObject>();
    public List<GameObject> panels = new List<GameObject>();

    [SerializeField] GameObject CRButton;
    [SerializeField] GameObject LQButton;
    [SerializeField] GameObject SHButton;
    [SerializeField] GameObject WHButton;
    [SerializeField] GameObject TGButton;

    [SerializeField] GameObject ComputerButton;
    [SerializeField] GameObject ComputerOneButton;
    [SerializeField] GameObject KitchenButton;
    [SerializeField] GameObject InvetoryButton;
    [SerializeField] GameObject ThinkeringButton;

    [SerializeField] Sprite[] backgrounds;
    [SerializeField] Image backgroundSprite;

    [SerializeField] GameObject animationFrame;

    public void Start()
    {
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[0];
        buttonCheck();
        CRButton.SetActive(false);
        animationFrame.SetActive(false);
    }

    public void buttonCheck()
    {
        foreach (GameObject button in buttons)
        {
            button.SetActive(true);
        }
    }
    
    public void panelCheck()
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(true);
        }
    }

    public void ControlRoom()
    {
        animationFrame.SetActive(true);
        StartCoroutine(countdownControlRoom());
        buttonCheck();
        CRButton.SetActive(false);

    }

    public void WindowHall()
    {
        animationFrame.SetActive(true);
        StartCoroutine(countdownWindowHall());
        buttonCheck();
        WHButton.SetActive(false);
    }

    public void LivingQus()
    {
        animationFrame.SetActive(true);
        StartCoroutine(countdownLivingQus());
        buttonCheck();
        LQButton.SetActive(false);
    }

    public void StorageHall()
    {
        animationFrame.SetActive(true);
        StartCoroutine(countdownStorageHall());
        buttonCheck();
        SHButton.SetActive(false);
    }

    public void Garage()
    {
        animationFrame.SetActive(true);
        StartCoroutine(countdownGarage());
        buttonCheck();
        TGButton.SetActive(false);
    }

    IEnumerator countdownControlRoom()
    {
        yield return new WaitForSecondsRealtime(0.85f);
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[0];
        yield return new WaitForSecondsRealtime(0.85f);
        animationFrame.SetActive(false);
    }
    IEnumerator countdownWindowHall()
    {
        yield return new WaitForSecondsRealtime(0.85f);
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[3];
        yield return new WaitForSecondsRealtime(0.85f);
        animationFrame.SetActive(false);
    }
    IEnumerator countdownLivingQus()
    {
        yield return new WaitForSecondsRealtime(0.85f);
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[1];
        yield return new WaitForSecondsRealtime(0.85f);
        animationFrame.SetActive(false);
    } 
    
    IEnumerator countdownStorageHall()
    {
        yield return new WaitForSecondsRealtime(0.85f);
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[2];
        yield return new WaitForSecondsRealtime(0.85f);
        animationFrame.SetActive(false);
    }

    IEnumerator countdownGarage()
    {
        yield return new WaitForSecondsRealtime(0.85f);
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[4];
        yield return new WaitForSecondsRealtime(0.85f);
        animationFrame.SetActive(false);
    }
}
