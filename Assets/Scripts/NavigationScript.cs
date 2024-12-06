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

    [SerializeField] GameObject controlbutton;
    [SerializeField] GameObject controlbuttonOne;
    [SerializeField] GameObject kitchenbutton;
    [SerializeField] GameObject inventorybutton;
    [SerializeField] GameObject thinkeringbutton;

    [SerializeField] Sprite[] backgrounds;
    [SerializeField] Image backgroundSprite;
    [SerializeField] TMP_Text backgroundText;

    [SerializeField] GameObject animationFrame;
    [SerializeField] AudioSource buttondown;
    [SerializeField] AudioSource doorWoosh;

    public void Start()
    {
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[0];
        backgroundText.text = "Control Room";
        buttonCheck();
        panelCheck();
        CRButton.SetActive(false);
        animationFrame.SetActive(false);
        controlbutton.SetActive(true);
        controlbuttonOne.SetActive(true);
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
            panel.SetActive(false);
        }
    }

    public void ControlRoom()
    {
        buttondown.Play();
        animationFrame.SetActive(true);
        StartCoroutine(countdownControlRoom());
        buttonCheck();
        panelCheck();
        CRButton.SetActive(false);
        controlbutton.SetActive(true);
        controlbuttonOne.SetActive(true);
    }

    public void WindowHall()
    {
        buttondown.Play();
        animationFrame.SetActive(true);
        StartCoroutine(countdownWindowHall());
        buttonCheck();
        panelCheck();
        WHButton.SetActive(false);
    }

    public void LivingQus()
    {
        buttondown.Play();
        animationFrame.SetActive(true);
        StartCoroutine(countdownLivingQus());
        buttonCheck();
        panelCheck();
        LQButton.SetActive(false);
        kitchenbutton.SetActive(true);
    }

    public void StorageHall()
    {
        buttondown.Play();
        animationFrame.SetActive(true);
        StartCoroutine(countdownStorageHall());
        buttonCheck();
        panelCheck();
        SHButton.SetActive(false);
        inventorybutton.SetActive(true);
    }

    public void Garage()
    {
        buttondown.Play();
        animationFrame.SetActive(true);
        StartCoroutine(countdownGarage());
        buttonCheck();
        panelCheck();
        TGButton.SetActive(false);
        thinkeringbutton.SetActive(true);
    }

    IEnumerator countdownControlRoom()
    {
        yield return new WaitForSecondsRealtime(0.85f);
        doorWoosh.Play();
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[0];
        backgroundText.text = "Control Room";
        yield return new WaitForSecondsRealtime(0.85f);
        animationFrame.SetActive(false);
    }
    IEnumerator countdownWindowHall()
    {
        yield return new WaitForSecondsRealtime(0.85f);
        doorWoosh.Play();
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[3];
        backgroundText.text = "Window Hallway";
        yield return new WaitForSecondsRealtime(0.85f);
        animationFrame.SetActive(false);
    }
    IEnumerator countdownLivingQus()
    {
        yield return new WaitForSecondsRealtime(0.85f);
        doorWoosh.Play();
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[1];
        backgroundText.text = "Living Quarters";
        yield return new WaitForSecondsRealtime(0.85f);
        animationFrame.SetActive(false);
    } 
    
    IEnumerator countdownStorageHall()
    {
        yield return new WaitForSecondsRealtime(0.85f);
        doorWoosh.Play();
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[2];
        backgroundText.text = "Storage Hallway";
        yield return new WaitForSecondsRealtime(0.85f);
        animationFrame.SetActive(false);
    }

    IEnumerator countdownGarage()
    {
        yield return new WaitForSecondsRealtime(0.85f);
        doorWoosh.Play();
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[4];
        backgroundText.text = "The Garage";
        yield return new WaitForSecondsRealtime(0.85f);
        animationFrame.SetActive(false);
    }

}
