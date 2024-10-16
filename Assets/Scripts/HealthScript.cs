using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [SerializeField] GameMenager gameMenager;

    public int sanity;
    public bool IsSanityLow;

    public int hunger;
    public float hungerClock;
    public bool IsHungry;
    public bool IsStarving;

    public int thirst;
    public float thisrtClock;

    [SerializeField] Image sanityMetar;
    [SerializeField] Image hungerMetar;
    [SerializeField] Image thirstMetar;

    private void Start()
    {
        sanity = 100;
        hunger = 100;

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
        if(hungerClock <= 0)
        {
            gameMenager.KillMe();
        }
        sanityMetar.fillAmount = hunger / 100;

        //Thirst clock:

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
    }
}
