using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    [SerializeField] public GameObject inventorybutton;
    [SerializeField] GameObject thinkeringbutton;
    [SerializeField] GameObject sleepingStation;

    [SerializeField] GameObject leftScroll;
    [SerializeField] GameObject rightScroll;

    [SerializeField] Sprite[] backgrounds;
    [SerializeField] GameObject[] CharacterSprites;
    [SerializeField] Image backgroundSprite;
    [SerializeField] TMP_Text backgroundText;
    [SerializeField] TMP_Text roomOverText;

    [SerializeField] public GameObject animationFrame;
    [SerializeField] AudioSource buttondown;
    [SerializeField] public AudioSource doorWoosh;

    public bool isInStorage;

    public void Start()
    {
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[5];
        backgroundText.text = "Control Room";
        animationFrame.SetActive(false);
    }

    public void buttonsOn()
    {
        foreach (GameObject button in buttons)
        {
            button.SetActive(true);
        }
    }
    public void buttonsOff()
    {
        foreach (GameObject button in buttons)
        {
            button.SetActive(false);
        }
    }

    public void panelCheck()
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }
    }

    public void boolCheck()
    {
        isInStorage = false;
    }

    public void CharactersOff()
    {
        foreach(GameObject sprite in CharacterSprites)
        {
            sprite.SetActive(false);
        }
    }

    public void CharactersOn()
    {
        foreach (GameObject sprite in CharacterSprites)
        {
            sprite.SetActive(true);
        }
    }

    public void CRHover()
    {
        roomOverText.text = "Control Room";
    }
    public void LQHover()
    {
        roomOverText.text = "Living Quarters";
    }
    public void SHHover()
    {
        roomOverText.text = "Storage Hallway";
    }
    public void WHHover()
    {
        roomOverText.text = "Window Hallway";
    }
    public void TGHover()
    {
        roomOverText.text = "The Garage";
    }

    public void ReverseHover()
    {
        roomOverText.text = string.Empty;
    }

    public void ControlRoom()
    {
        buttondown.Play();
        animationFrame.SetActive(true);
        StartCoroutine(countdownControlRoom());
        CharactersOff();
        buttonsOn();
        panelCheck();
        boolCheck();
        CRButton.SetActive(false);
        controlbutton.SetActive(true);
        controlbuttonOne.SetActive(true);
    }

    public void WindowHall()
    {
        buttondown.Play();
        animationFrame.SetActive(true);
        StartCoroutine(countdownWindowHall());
        CharactersOff();
        buttonsOn();
        panelCheck();
        boolCheck();
        WHButton.SetActive(false);
    }

    public void LivingQus()
    {
        buttondown.Play();
        animationFrame.SetActive(true);
        StartCoroutine(countdownLivingQus());
        CharactersOff();
        buttonsOn();
        panelCheck();
        boolCheck();
        LQButton.SetActive(false);
        kitchenbutton.SetActive(true);
        
    }

    public void SleepingDoc()
    {
        buttondown.Play();
        kitchenbutton.SetActive(false);
        rightScroll.SetActive(false);
        leftScroll.SetActive(true);
        sleepingStation.SetActive(true);
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[7];
    }
    
    public void BackToKitchen()
    {
        buttondown.Play();
        kitchenbutton.SetActive(true);
        rightScroll.SetActive(true);
        leftScroll.SetActive(false);
        sleepingStation.SetActive(false);
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[1];
    }

    public void StorageHall()
    {
        buttondown.Play();
        animationFrame.SetActive(true);
        StartCoroutine(countdownStorageHall());
        CharactersOff();
        buttonsOn();
        panelCheck();
        boolCheck();
        isInStorage = true;
        SHButton.SetActive(false);
        inventorybutton.SetActive(true);
    }

    public void Garage()
    {
        buttondown.Play();
        animationFrame.SetActive(true);
        StartCoroutine(countdownGarage());
        CharactersOff();
        buttonsOn();
        panelCheck();
        boolCheck();
        TGButton.SetActive(false);
        thinkeringbutton.SetActive(true);
    }

    IEnumerator countdownControlRoom()
    {
        yield return new WaitForSecondsRealtime(0.85f);
        doorWoosh.Play();
        backgroundSprite.GetComponent<Image>().sprite = backgrounds[5];
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
        rightScroll.SetActive(true);
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
