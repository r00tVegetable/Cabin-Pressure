using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventroyMenager : MonoBehaviour
{
    public int food;
    public int water;
    public int alloy;
    public int carbon;

    public void Start()
    {
        food = 42;
        water = 21;
        alloy = 45;
        carbon = 15;
    }
}
