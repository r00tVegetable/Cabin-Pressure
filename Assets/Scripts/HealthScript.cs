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
        sanityMetar.fillAmount = sanity / 100;
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
        hungerMetar.fillAmount = hunger / 100;

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

        //Thirst clock:
        thirstClock += Time.deltaTime;
        thirstMetar.fillAmount = thirst / 10;

        if(thirstClock >= 720)
        {
            thirstClock = 0;
            thirst -= 1;
            LowerSanity(1);
        }
        if(thirst <= 0)
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
        hunger += amount;
        AddSanity(amount);
        thirst++;
        Debug.Log($"current hunger:{hunger}");
    }

    public void Drink()
    {
        thirstClock = 0;
        thirst = 10f;
        AddSanity(1);
        Debug.Log($"current thirst:{thirst }");
    }
}
