using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleScript : MonoBehaviour
{
    [SerializeField] GameObject SubtitleText;
    [SerializeField] TMP_Text textSub;
    [SerializeField] GameObject textPopup;

    public void Start()
    {
        SubtitleText.SetActive(true);
        textSub.text = string.Empty;
    }
    //textSub.text = "";
    //yield return new WaitForSecondsRealtime(f);
    public void IntroSequance()
    {
        StartCoroutine(IntroSQ());
    }

    IEnumerator IntroSQ()
    {
        textSub.text = "To anyone currently semi-permanently Earthbound…";
        yield return new WaitForSecondsRealtime(4f);
        textSub.text = string.Empty;
        yield return new WaitForSecondsRealtime(1.5f);
        textSub.text = "I'm sorry, but if I ever hear you complaining about the weather down there…";
        yield return new WaitForSecondsRealtime(5f);
        textSub.text = "I will happily invite you to try floating in the Exosphere for a few weeks.";
        yield return new WaitForSecondsRealtime(6f);
        textSub.text = string.Empty;
        yield return new WaitForSecondsRealtime(11.5f);
        textSub.text = "Vanessa: Shit, shit, shit";
        yield return new WaitForSecondsRealtime(1.5f);
        textSub.text = string.Empty;
        yield return new WaitForSecondsRealtime(4f);
       
        yield return new WaitForSecondsRealtime(1.5f);

    }
}

