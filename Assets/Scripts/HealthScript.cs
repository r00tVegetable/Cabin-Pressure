using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    [SerializeField] GameMenager gameMenager;
    public int sanity;
    public int hunger;

    public bool IsSanityLow;

    public void Update()
    {
        //Sanity checker:
        if (sanity > 25)
        {
            IsSanityLow = false;
        }
        if (sanity <= 25)
        {
            IsSanityLow = true;
        }
    }

    public void LowerSanity(int value)
    {
        sanity -= value;
    }

    public void AddSanity(int value)
    {
        sanity += value;
    }
}
