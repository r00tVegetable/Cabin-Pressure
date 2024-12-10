using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VNSequanceScript : MonoBehaviour
{
    [SerializeField] Image Vanessa;
    [SerializeField] Image VanessaFaceFront;
    [SerializeField] Image VanessaFaceSide;
    [SerializeField] Image Jerry;

    [SerializeField] GameObject VanessaFaceFrontGO;
    [SerializeField] GameObject VanessaFaceSideGO;
    [SerializeField] GameObject JerryGO;

    [SerializeField] Sprite[] VanessaFaceSprite;
    [SerializeField] Sprite[] VanessaPoses;
    [SerializeField] Sprite[] JerrySprites;

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
    [SerializeField] AudioSource VoiceOversSource9a;
    [SerializeField] AudioSource VoiceOversSource10;
    [SerializeField] AudioSource VoiceOversSource11;
    [SerializeField] AudioSource VoiceOversSource12;
    [SerializeField] AudioSource VoiceOversSource13;
    [SerializeField] AudioSource VoiceOversSource14;
    [SerializeField] AudioSource VoiceOversSource15;
    [SerializeField] AudioSource VoiceOversSource16;
    [SerializeField] AudioSource VoiceOversSource17;
    [SerializeField] AudioSource VoiceOversSource18;
    [SerializeField] AudioSource VoiceOversSource19;
    [SerializeField] AudioSource VoiceOversSource20;
    [SerializeField] AudioSource VoiceOversSource21;
    [SerializeField] AudioSource VoiceOversSource22;
    [SerializeField] AudioSource VoiceOversSource23;


    [SerializeField] AudioSource ChimeUI1;
    [SerializeField] AudioSource ChimeUI2;
    [SerializeField] AudioSource ChimeUI3;

    [SerializeField] TMP_Text VOSubtitle;

    public int slideNo;

    [SerializeField] NavigationScript NavigationScript;
    [SerializeField] UIMenager UIMenager;
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
        JerryGO.SetActive(false);
        StartCoroutine(slideZero());
    }
    
    public void Update()
    {
        if (slideNo == 9 && NavigationScript.isInStorage == true)  
        {
            StartCoroutine(CharacterDelay());
            VOSubtitle.text = string.Empty;
            slideNo = 10;
            SlideChecker();
        }
        if (slideNo == 12 && UIMenager.inventoryPannel.activeInHierarchy == true)
        {
            slideNo = 13;
            VOSubtitle.text = "Vanessa: Currently, this station has about two weeks worth of food packets and only a week’s worth of drinking water. ";
            VoiceOversSource10.Play();
            StartCoroutine(skipDelay());
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
            NavigationScript.buttonsOff();
            StartCoroutine(slideTen());
        }
        if (slideNo == 11)
        {
            ChimeUI1.Play();
            StartCoroutine(slideEleven());
            StartCoroutine(skipDelay());
        }
        if (slideNo == 12)
        {
            VOSubtitle.text = "OBJECTIVE: Click on the Inventory Terminal on the wall to check your current supplies.";
            NavigationScript.inventorybutton.SetActive(true);
        }
        
        if(slideNo == 14)
        {
            UIMenager.inventoryPannel.SetActive(false);
            NavigationScript.buttonsOff();
            VanessaFaceSide.sprite = VanessaFaceSprite[1];
            VOSubtitle.text = "Vanessa: So, I am going to wait here for the next week and after that I will be forced to sound and SOS signal.";
            VoiceOversSource11.Play();
            StartCoroutine(skipDelay());
        }
        if(slideNo == 15)
        {
            VanessaFaceSide.sprite = VanessaFaceSprite[2];
            VOSubtitle.text = "Vanessa: I want it on record that I am doing everything in my power not to require an emergency extraction, but I will call for one after my supplies run out.";
            VoiceOversSource12.Play();
            StartCoroutine(skipDelay());
        }
        if(slideNo == 16)
        {
            VanessaFaceSide.sprite = VanessaFaceSprite[0];
            Vanessa.sprite = VanessaPoses[1];
            VOSubtitle.text = "Vanessa: Best case scenario, it won’t come to that. Coleman out. Stop recording.";
            VoiceOversSource13.Play();
            StartCoroutine(skipDelay());
        }
        if(slideNo == 17)
        {
            Vanessa.sprite = VanessaPoses[0];
            VanessaFaceSide.sprite = VanessaFaceSprite[0];
            VOSubtitle.text = "Station UI: Recording stopped. Posterity protocol activated.";
            VoiceOversSource14.Play();
            StartCoroutine(skipDelay());
        }
        if (slideNo == 18)
        {
            VOSubtitle.text = "Jerry: (From the closet) Wow, that company of yours must be a real piece of work, huh?";
            VoiceOversSource15.Play();
            StartCoroutine(skipDelay());
        }
        if (slideNo == 19)
        {
            VOSubtitle.text = "Vanessa: Oh, you have no idea.";
            VoiceOversSource16.Play();
            StartCoroutine(skipDelay());
        }
        if (slideNo ==  20)
        {
            VOSubtitle.text = "Jerry: (From the closet) Ma’am, could I make a small request from you?";
            VoiceOversSource17.Play();
            StartCoroutine(skipDelay());
        }
        if (slideNo ==  21)
        {
            VOSubtitle.text = "Vanessa: Only if you must?";
            VoiceOversSource18.Play();
            StartCoroutine(skipDelay());
        }
        if (slideNo == 22)
        {
            VOSubtitle.text = "Jerry: (From the closet) My battery’s running very low and it’s so dark in here… Would you allow me a trip to my charging station?";
            VoiceOversSource19.Play();
            StartCoroutine(skipDelay());
        }
        if (slideNo ==  23)
        {
            VOSubtitle.text = "Jerry: (From the closet) It would only be a short trip, I promise to stay out of your way.";
            VoiceOversSource20.Play();
            StartCoroutine(skipDelay());
        }
        if (slideNo ==  24)
        {
            VOSubtitle.text = "Vanessa: *deep sight* Okay, fine. I’m not a monster.";
            VoiceOversSource21.Play();
            StartCoroutine(slideJerry());
            StartCoroutine(skipDelay());
        }
        if (slideNo ==  25)
        {
            VOSubtitle.text = "Jerry: Oh, that you so much, ma’am!";
            VoiceOversSource22.Play();
            Jerry.sprite = JerrySprites[2];
            StartCoroutine(skipDelay());
        }
        if (slideNo == 26)
        {
            VOSubtitle.text = "Jerry:  I better hurry before I shoot down.";
            Jerry.sprite = JerrySprites[1];
            VoiceOversSource23.Play();
            StartCoroutine(JerryOut());
        }
        else 
        {
            return; 
        }
    }
    //VOSubtitle.text = "";
    //VOSubtitle.text = "Vanessa: ";
    //VOSubtitle.text = "Station UI: ";
    //yield return new WaitForSecondsRealtime(f);

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

    IEnumerator slideEleven()
    {
        yield return new WaitForSecondsRealtime(1f);
        VOSubtitle.text = "Station UI: Recording resumed.";
        VoiceOversSource9a.Play();
    }

    IEnumerator slideJerry()
    {
        yield return new WaitForSecondsRealtime(2.5f);
        NavigationScript.doorWoosh.Play();
        NavigationScript.animationFrame.SetActive(true);
        yield return new WaitForSecondsRealtime(0.85f);
        JerryGO.SetActive(true);
        Jerry.sprite = JerrySprites[0];
        yield return new WaitForSecondsRealtime(0.85f);
        NavigationScript.animationFrame.SetActive(false);
    }

    IEnumerator JerryOut()
    {
        yield return new WaitForSecondsRealtime(3f);
        JerryGO.SetActive(false);
        NavigationScript.doorWoosh.Play();
        NavigationScript.buttonsOn();
        VOSubtitle.text = "OBJECTIVE: Recover some of your Sanity by resting in the Sleeping Pod in your Living Quarters.";

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
