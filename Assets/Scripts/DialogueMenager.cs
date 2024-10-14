using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueMenager : MonoBehaviour
{
    [SerializeField] DialogueParser parser;
    [SerializeField] public Text dialogueBox;
    [SerializeField] public Text nameBox;
    [SerializeField] public GameObject choiceBox;

    public string dialogue, characterName;
    public int lineNum;
    int pose;
    string position;
    string[] options;
    public bool playerTalking;
    List<Button> buttons = new List<Button>();

    void Start()
    {
        dialogue = "";
        characterName = "";
        pose = 0;
        position = "L";
        playerTalking = false;
        parser = GameObject.Find("DialogueParser").GetComponent<DialogueParser>();
        lineNum = 0;
    }
}
