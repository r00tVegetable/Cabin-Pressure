using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventroyMenager : MonoBehaviour
{
    public int food;
    public float water;
    public int alloy;
    public int carbon;

    [SerializeField] TMP_Text foodText;
    [SerializeField] TMP_Text waterText;
    [SerializeField] TMP_Text alloyText;
    [SerializeField] TMP_Text carbonText;

    public void Start()
    {
        food = 42;
        water = 21;
        alloy = 45;
        carbon = 15;
    }

    public void Update()
    {
        foodText.text = $"{food} packs";
        waterText.text = string.Format("{0:00}", water) + " L";
        alloyText.text = $"{alloy} kg";
        carbonText.text = $"{carbon} kg";
    }
}
