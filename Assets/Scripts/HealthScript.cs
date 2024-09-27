using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    [SerializeField] GameMenager gameMenager;
    public int sanity;
    public bool IsSanityLow;

    public float hungerClock;
    public int hunger;
    public bool IsHungry;
    public bool IsStarving;

    private void Start()
    {//might cause issues later with saves, check back
        sanity = 100;
        hunger = 0;
        hungerClock = 0;
    }

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

        //Hunger clock:
        hungerClock += Time.deltaTime;
        if(hungerClock >= 480)
        {
            hungerClock = 0;
            hunger++;
            sanity -= 2;
        }
        if(hungerClock >= 90)
        {
            gameMenager.KillMe();
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

    public void Eat(int amount)
    {
        hungerClock = 0;
        hunger -= amount;
        sanity += amount;
    }
}
