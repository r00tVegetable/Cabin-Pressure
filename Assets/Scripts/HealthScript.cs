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
    //public bool IsHungry;
    //public bool IsStarving;

    public float thirst;
    public float thirstClock;

    [SerializeField] Image sanityMetar;
    [SerializeField] Image hungerMetar;
    [SerializeField] Image thirstMetar;

    [SerializeField] AudioSource waterSound;
    [SerializeField] AudioSource foodSound;

    [SerializeField] InventroyMenager inventroyMenager;

    private void Start()
    {
        sanity = 40;
        hunger = 7;
        thirst = 6;

        hungerClock = 0;
    }

    public void Update()
    {
        //Sanity checker:
        sanityMetar.fillAmount = sanity / 100;
        if (sanity > 25)
        {
            IsSanityLow = false;
        }
        if (sanity <= 25)
        {
            IsSanityLow = true;
            //add vanessa's sick sprite here.
            //break the displays of other stats somehow.
        }

        //Hunger clock:
        hungerClock += Time.deltaTime;
        hungerMetar.fillAmount = hunger / 10;

        if (hungerClock >= 480)
        {
            hungerClock = 0;
            hunger--;
            LowerSanity(2);
        }
        if(hunger > 10)
        {
            hunger = 10f;
        }
        if (hunger <= 0)
        {
            gameMenager.KillMe();
        }

        //Thirst clock:
        thirstClock += Time.deltaTime;
        thirstMetar.fillAmount = thirst / 10;

        if (thirstClock >= 720)
        {
            thirstClock = 0;
            thirst -= 1;
            LowerSanity(1);
        }
        if (thirst <= 0)
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
        foodSound.Play();
        hungerClock = 0;
        hunger += amount;
        AddSanity(amount);
        inventroyMenager.food -= amount;
        thirst++;
    }

    public void Drink()
    {
        waterSound.Play();
        thirstClock = 0;
        thirst = 10f;
        AddSanity(1);
        inventroyMenager.water -= 1.5f;
    }
}
