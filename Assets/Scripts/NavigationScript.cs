using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationScript : MonoBehaviour
{
    public List<GameObject> buttons = new List<GameObject>();

    [SerializeField] GameObject CRButton;
    [SerializeField] Animator doorAnimator;
    [SerializeField] GameObject animationFrame;

    public void Start()
    {
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

    public void WindowHall()
    {
        animationFrame.SetActive(true);
        doorAnimator.SetTrigger("DoorTransition");
        //SceneManager.LoadScene(5);
    }

    public void ControlRoom()
    {
        animationFrame.SetActive(true);
        doorAnimator.SetTrigger("DoorTransition");
        //SceneManager.LoadScene(1);
    }

    public void LivingQus()
    {
        animationFrame.SetActive(true);
        doorAnimator.SetTrigger("DoorTransition");
        //SceneManager.LoadScene(2);
    }

    public void StorageHall()
    {
        animationFrame.SetActive(true);
        doorAnimator.SetTrigger("DoorTransition");
        //SceneManager.LoadScene(3);
    }

    public void Garage()
    {
        animationFrame.SetActive(true);
        doorAnimator.SetTrigger("DoorTransition");
        StartCoroutine(countdown());
        buttonCheck();
        //deactivate this button
    }

    IEnumerator countdown()
    {
        yield return new WaitForSecondsRealtime(3);
        animationFrame.SetActive(false);
    }
}
