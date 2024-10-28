using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LQ_UI : MonoBehaviour
{
    [SerializeField] GameObject KitchenPannel;

    public void Start()
    {
        KitchenPannel.SetActive(false);
    }

    public void OpenKitchenPanel()
    {
        KitchenPannel.SetActive(true);
    }

    public void CloseKitchenPanel()
    {
        KitchenPannel.SetActive(false);
    }

    public void Update()
    {
        if(KitchenPannel.activeInHierarchy == true)
        {

        }
    }
}
