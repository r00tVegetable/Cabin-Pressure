using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StaticScript : MonoBehaviour
{
    public static StaticScript Instance { get; private set; }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        // If there is an instance, and it's not me, delete myself.
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
}
