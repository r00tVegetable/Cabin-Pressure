using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleScript : MonoBehaviour
{
    [SerializeField] GameObject SubtitleText;
    [SerializeField] TMP_Text textSub;
    [SerializeField] GameObject textPopup;

    public void Start()
    {
        textPopup.SetActive(false);
        SubtitleText.SetActive(true);
        textSub.text = string.Empty;
    }
    
    public void IntroSequance()
    {
        StartCoroutine(IntroSQ());
    }

    IEnumerator IntroSQ()
    {
        textSub.text = "To anyone currently semi-permanently Earthbound…";
        yield return new WaitForSecondsRealtime(4f);
        textSub.text = string.Empty;
        yield return new WaitForSecondsRealtime(2f);
        textSub.text = "I'm sorry, but if I ever hear you complaining about the weather down there…";
        yield return new WaitForSecondsRealtime(5f);
        textSub.text = "I will happily invite you to try floating in the Exosphere for a few weeks.";
        yield return new WaitForSecondsRealtime(5.5f);
        textSub.text = string.Empty;
        yield return new WaitForSecondsRealtime(11.5f);
        textSub.text = "Vanessa: Shit, shit, shit!";
        yield return new WaitForSecondsRealtime(1.5f);
        textSub.text = string.Empty;
        yield return new WaitForSecondsRealtime(5.5f);
        textPopup.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        textSub.text = "Vanessa: This wasn’t my first time getting hit by a solar flare, but it was the first time the whole Station died on me.";
        yield return new WaitForSecondsRealtime(3f);
        textPopup.SetActive(false);
        yield return new WaitForSecondsRealtime(3.25f);
        textSub.text = "Vanessa: Luckily, I managed to get all the life support systems up and running again.";
        yield return new WaitForSecondsRealtime(3.5f);
        textSub.text = "Vanessa: Would have had to call Mayday otherwise…";
        yield return new WaitForSecondsRealtime(3f);
        textSub.text = "Vanessa: ...And I really can’t afford the rescue fees right now.";
        yield return new WaitForSecondsRealtime(3.75f);
        textSub.text = "Vanessa: Less lucky is that my comms are still fried, so I have no idea why my relief team is three days late.";
        yield return new WaitForSecondsRealtime(6.25f);
        textSub.text = "Vanessa: Solar storm or not, this is way too long to leave me here.";
        yield return new WaitForSecondsRealtime(4.25f);
        textSub.text = "Vanessa: I’m either about to get paid a fortune in overtime… or something is seriously wrong.";
        yield return new WaitForSecondsRealtime(6f);
        textSub.text = string.Empty;
        yield return new WaitForSecondsRealtime(22f);
        textSub.text = "Jerry: (From the closet) Oh no, what if they forgot about you?";
        yield return new WaitForSecondsRealtime(4f);
        textSub.text = "Vanessa: Shut up, Jerry!";
        yield return new WaitForSecondsRealtime(1.5f);
        textSub.text = string.Empty;
    }
}

