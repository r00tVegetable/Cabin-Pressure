using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

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
            StartCoroutine(slideFour());
        }
        if(slideNo == 6)
        {
            VanessaFaceFront.sprite = VanessaFaceSprite[10];
            VOSubtitle.text = "Vanessa: The comms system was critically damaged in the solar storm a few days ago. I have no way of contacting headquarters… Or anyone else for that matter.";
            VoiceOversSource6.Play();
            StartCoroutine(skipDelay());
        }
        if (slideNo == 7)
        {
            VanessaFaceFront.sprite = VanessaFaceSprite[12];
            VOSubtitle.text = "Vanessa: All other crucial systems are functional. Pause recording.";
            VoiceOversSource7.Play();
            StartCoroutine(slideSeven());
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

    IEnumerator slideFour()
    {
        yield return new WaitForSecondsRealtime(1f);
        VanessaFaceSide.sprite = VanessaFaceSprite[7];
        VOSubtitle.text = "Vanessa: The grace period of 72 h after a missed scheduled pick up post-expiration of a work contract officially expired.";
        VoiceOversSource5.Play();
        StartCoroutine(skipDelay());
    }

    IEnumerator slideSeven()
    {
        yield return new WaitForSecondsRealtime(10f);
        ChimeUI2.Play();
        StartCoroutine(skipDelay());
        yield return new WaitForSecondsRealtime(2f);
        ChimeUI3.Play();
    }

    IEnumerator skipDelay()
    {
        yield return new WaitForSecondsRealtime(1f);
        buttonForNext.SetActive(true);
    }
}
