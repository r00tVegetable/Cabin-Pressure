using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTerminal : MonoBehaviour
{
    [SerializeField] GameObject InventoryPannel;
    public void Start()
    {
        InventoryPannel.SetActive(false);
    }

    public void ActivateInventory()
    {
        InventoryPannel.SetActive(true);
    }

    public void DeactivateInventory()
    {
        InventoryPannel.SetActive(false);
    }
}
