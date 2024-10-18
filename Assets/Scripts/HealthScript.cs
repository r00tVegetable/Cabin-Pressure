using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [SerializeField] GameMenager gameMenager;

    public float sanity;
    public bool IsSanityLow;

    public float hunger;
    public float hungerClock;
    public bool IsHungry;
    public bool IsStarving;

    public float thirst;
    public float thirstClock;

    [SerializeField] Image sanityMetar;
    [SerializeField] Image hungerMetar;
    [SerializeField] Image thirstMetar;

    private void Start()
    {
        sanity = 100;
        hunger = 100;
        thirst = 10;

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
        sanityMetar.fillAmount = sanity / 100;

        //Hunger clock:
        hungerClock += Time.deltaTime;
        if(hungerClock >= 480)
        {
            hungerClock = 0;
            hunger--;
            LowerSanity(2);
        }
        if(hunger <= 0)
        {
            gameMenager.KillMe();
        }
        hungerMetar.fillAmount = hunger / 100;

        //Thirst clock:
        thirstClock += Time.deltaTime;
        if(thirstClock >= 720)
        {
            thirstClock = 0;
            thirst--;
            LowerSanity(1);
        }
        if(thirst <= 0)
        {
            gameMenager.KillMe();
        }
        thirstMetar.fillAmount = thirst / 10;

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
        hunger += amount;
        sanity += amount;
        thirst++;
    }

    public void Drink()
    {
        thirstClock = 0;
        thirst = 10;
        sanity++;
    }
}
