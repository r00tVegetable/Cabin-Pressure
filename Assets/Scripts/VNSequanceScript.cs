using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;

public class VNSequanceScript : MonoBehaviour
{
    [SerializeField] Image Vanessa;
    [SerializeField] Image VanessaFaceFront;
    [SerializeField] Image VanessaFaceSide;

    [SerializeField] GameObject VanessaFaceFrontGO;
    [SerializeField] GameObject VanessaFaceSideGO;

    [SerializeField] Sprite[] VanessaFaceSprite;
    [SerializeField] Sprite[] VanessaPoses;

    [SerializeField] AudioSource VoiceOversSource0;
    [SerializeField] AudioSource VoiceOversSource1;
    [SerializeField] AudioSource VoiceOversSource2;
    [SerializeField] AudioSource VoiceOversSource3;
    [SerializeField] AudioSource VoiceOversSource4;
    [SerializeField] AudioSource VoiceOversSource5;
    [SerializeField] AudioSource VoiceOversSource6;
    [SerializeField] AudioSource VoiceOversSource7;
    [SerializeField] AudioSource VoiceOversSource8;
    [SerializeField] AudioSource VoiceOversSource9;


    [SerializeField] AudioSource ChimeUI1;
    [SerializeField] AudioSource ChimeUI2;
    [SerializeField] AudioSource ChimeUI3;

    [SerializeField] TMP_Text VOSubtitle;

    public int slideNo;

    [SerializeField] NavigationScript NavigationScript;
    [SerializeField] GameObject buttonForNext;

    public void Awake()
    {
        buttonForNext.SetActive(false);
        NavigationScript.panelCheck();
        NavigationScript.buttonsOff();
        VOSubtitle.text = string.Empty;
    }
    public void Start()
    {
        slideNo = 0;
        Vanessa.sprite = VanessaPoses[0];
        VanessaFaceSide.sprite = VanessaFaceSprite[0];
        VanessaFaceFrontGO.SetActive(false);
        StartCoroutine(slideZero());
    }
    //VOSubtitle.text = "";
    //VOSubtitle.text = "Vanessa: ";
    //VOSubtitle.text = "Station UI: ";
    //yield return new WaitForSecondsRealtime(f);

    public void Update()
    {
        if (slideNo == 9 && NavigationScript.isInStorage == true)  
        {
            NavigationScript.buttonsOff();
            StartCoroutine(CharacterDelay());
            VOSubtitle.text = string.Empty;
            slideNo = 10;
        }
    }

    public void SlideChecker()
    {
        if (slideNo == 0)
        {
            return;
        }
        if (slideNo == 1)
        {
            ChimeUI1.Play();
            StartCoroutine(slideOne());
        }
        if(slideNo == 2)
        {
            Vanessa.sprite = VanessaPoses[1];
            VOSubtitle.text = "Vanessa: Yes, continue.";
            VoiceOversSource2.Play();
            StartCoroutine(skipDelay());
        }
        if (slideNo == 3)
        {
            VOSubtitle.text = "Station UI: Alright. All current station data recorded. Starting voice only recording.";
            VoiceOversSource3.Play();
            StartCoroutine(skipDelay());
        }
        if(slideNo == 4)
        {
            Vanessa.sprite = VanessaPoses[7];
            VanessaFaceSideGO.SetActive(false);
            VanessaFaceFrontGO.SetActive(true);
            VanessaFaceFront.sprite = VanessaFaceSprite[12];
            VOSubtitle.text = "Vanessa: This is Vanessa Coleman speaking, employee number 226-129.";
            VoiceOversSource4.Play();
            StartCoroutine(skipDelay());
        }
        if (slideNo == 5)
        {
            VanessaFaceSide.sprite = VanessaFaceSprite[7];
            VOSubtitle.text = "Vanessa: The grace period of 72 h after a missed scheduled pick up post-expiration of a work contract officially expired.";
            VoiceOversSource5.Play();
            StartCoroutine(skipDelay());
        }
        if(slideNo == 6)
        {
            VanessaFaceFront.sprite = VanessaFaceSprite[10];
            VOSubtitle.text = "Vanessa: I am still on my assigned post.Station registration code is VOC - 916.";
            VoiceOversSource6.Play();
            StartCoroutine(skipDelay());
        }
        if (slideNo == 7)
        {
            Vanessa.sprite = VanessaPoses[8];
            VOSubtitle.text = "Vanessa: The comms system was critically damaged in the solar storm a few days ago. I have no way of contacting headquarters… Or anyone else for that matter.";
            VoiceOversSource7.Play();
            StartCoroutine(skipDelay());
        }
        if (slideNo == 8)
        {
            VanessaFaceFront.sprite = VanessaFaceSprite[12];
            VOSubtitle.text = "Vanessa: All other crucial systems are functional. Pause recording.";
            VoiceOversSource8.Play();
            StartCoroutine(slideEight());
            StartCoroutine(skipDelay());
        }
        if(slideNo == 9)
        {
            NavigationScript.buttonsOn();
            VanessaFaceSideGO.SetActive(true);
            VanessaFaceFrontGO.SetActive(false);
            Vanessa.sprite = VanessaPoses[0];
            VanessaFaceSide.sprite = VanessaFaceSprite[0];
            VOSubtitle.text = "OBJECTIVE: Go to the Storage Hallway. Use the mini-map in the lower right corner to navigate the Station.";
        }
        if (slideNo == 10)
        {
            Vanessa.sprite = VanessaPoses[0];
            VanessaFaceSide.sprite = VanessaFaceSprite[0];
            StartCoroutine(slideTen());
        }
        if (slideNo == 11)
        {

        }
        else 
        {
            return; 
        }
    }

    public void nextButton()
    {
        slideNo++;
        SlideChecker();
        buttonForNext.SetActive(false);
    }

    IEnumerator slideZero()
    {
        yield return new WaitForSecondsRealtime(1f);
        VoiceOversSource0.Play();
        VOSubtitle.text = "Vanessa: Station, start a voice only recording. Save all current local data. Store a copy on the black box automatically.";
        StartCoroutine(skipDelay());
    }

    IEnumerator slideOne()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        VOSubtitle.text = "Station UI: You are attempting to initiate actions marked under Posterity Protocol. All crucial systems are currently stable. Do you wish to continue regardless?";
        VoiceOversSource1.Play();
        StartCoroutine(skipDelay());
    }

    IEnumerator slideEight()
    {
        yield return new WaitForSecondsRealtime(4f);
        ChimeUI2.Play();
        yield return new WaitForSecondsRealtime(2f);
        ChimeUI3.Play();
    }

    IEnumerator slideTen()
    {
        yield return new WaitForSecondsRealtime(1f);
        VoiceOversSource9.Play();
        VOSubtitle.text = "Vanessa: Resume recording.";
        StartCoroutine(skipDelay());
    }

    IEnumerator skipDelay()
    {
        yield return new WaitForSecondsRealtime(1f);
        buttonForNext.SetActive(true);
    }

    IEnumerator CharacterDelay()
    {
        yield return new WaitForSecondsRealtime(0.85f);
        NavigationScript.CharactersOn();
    }
}
