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

    [SerializeField] Sprite[] backgrounds;

    public void Start()
    {
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
            if (controlPanel.activeInHierarchy == true)
            {
                controlPanel.SetActive(false);
            }
            if (kitchenPannel.activeInHierarchy == true)
            {
                kitchenPannel.SetActive(false);
            }
            if (inventoryPannel.activeInHierarchy == true)
            {
                inventoryPannel.SetActive(false);
            }
            else
            {
                pauseScreen.SetActive(true);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pauseScreen.activeInHierarchy == true)
        {
            pauseScreen.SetActive(false);
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

}
