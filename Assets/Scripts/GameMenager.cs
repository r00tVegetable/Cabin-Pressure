using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMenager : MonoBehaviour
{
    [SerializeField] bool drainOxygen;
    [SerializeField] TMP_Text O2Display;
    public float oxygen;

    private void Start()
    {
        oxygen = 100f;
        drainOxygen = false;
    }

    public void Update()
    {
        if (drainOxygen == true)
        {
            oxygen -= Time.deltaTime;
        }

        O2Display.text = $"Oxygen Saturation: {oxygen}%";
    }
}
