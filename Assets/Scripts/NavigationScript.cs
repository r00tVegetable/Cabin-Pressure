using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationScript : MonoBehaviour
{
    public List<GameObject> buttons = new List<GameObject>();
    [SerializeField] GameObject CRButton;

    public void Start()
    {
        CRButton.SetActive(false);
    }

    public void buttonCheck(GameObject disableThis)
    {
        foreach (GameObject button in buttons)
        {
            button.SetActive(true);
        }

        disableThis.SetActive(false);
    }

    public void WindowHall()
    {
        SceneManager.LoadScene(5);
    }

    public void ControlRoom()
    {
        SceneManager.LoadScene(1);
    }

    public void LivingQus()
    {
        SceneManager.LoadScene(2);
    }

    public void StorageHall()
    {
        SceneManager.LoadScene(3);
    }

    public void Garage()
    {
        SceneManager.LoadScene(4);
    }
}
