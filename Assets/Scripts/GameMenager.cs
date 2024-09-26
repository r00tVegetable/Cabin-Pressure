using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMenager : MonoBehaviour
{
    [SerializeField] GameObject theStatics;

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
        O2Display.text = $"Oxygen Saturation: {oxygen}%";

        if (drainOxygen == true)
        {
            oxygen -= Time.deltaTime;
        }

        if (oxygen <= 0)
        {

        }

    }
}
