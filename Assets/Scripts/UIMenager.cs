using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenager : MonoBehaviour
{
    [SerializeField] GameObject pauseScreen;
    [SerializeField] GameObject controlPanel;
    [SerializeField] GameObject kitchenPannel;
    [SerializeField] GameObject inventoryPannel;
    [SerializeField] GameObject thinkeringPannel;

    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        pauseScreen.SetActive(false);
        controlPanel.SetActive(false);
        kitchenPannel.SetActive(false);
        inventoryPannel.SetActive(false);
    }

    public void Update()
    {
        //Pause Screen Control
        if (Input.GetKeyDown(KeyCode.Escape) && pauseScreen.activeInHierarchy == false)
        {
            if (controlPanel.activeInHierarchy == true || kitchenPannel.activeInHierarchy == true || inventoryPannel.activeInHierarchy == true || thinkeringPannel.activeInHierarchy == true)
            {
                controlPanel.SetActive(false);
                kitchenPannel.SetActive(false);
                inventoryPannel.SetActive(false);
                thinkeringPannel.SetActive(false);
            }
            else
            {
                pauseScreen.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pauseScreen.activeInHierarchy == true)
        {
            pauseScreen.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
        }

    }

    public void BackToMain()
    {
        pauseScreen.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void OpenPanel()
    {
        controlPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        controlPanel.SetActive(false);
    }
    public void ActivateInventory()
    {
        inventoryPannel.SetActive(true);
    }

    public void DeactivateInventory()
    {
        inventoryPannel.SetActive(false);
    }

    public void OpenKitchenPanel()
    {
        kitchenPannel.SetActive(true);
    }

    public void CloseKitchenPanel()
    {
        kitchenPannel.SetActive(false);
    }

    public void OpenThinkering()
    {
        thinkeringPannel.SetActive(true);
    }

    public void CloseThinkering() 
    { 
        thinkeringPannel.SetActive(false);
    }
}
