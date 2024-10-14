using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class DialogueParser : MonoBehaviour
{
    struct DialogueLine
    {
        public string name;
        public string content;
        public int pose;
        public string position;
        public string[] options;

        public DialogueLine(string Name, string Content, int Pose, string Position)
        {
            name = Name;
            content = Content;
            pose = Pose;
            position = Position;
            options = new string[0];
        }
    }

    List<DialogueLine> lines;

    private void Start()
    {
        string file = "Assets/Dialogue";
        string sceneNum = EditorApplication.currentScene;
        sceneNum = Regex.Replace(sceneNum, "[^0-9]", "");
        file += sceneNum;
        file += ".txt";

        lines = new List<DialogueLine>();

        LoadDialogue(file);
    }

    void LoadDialogue(string filename)
    {
        string line;
        StreamReader r = new StreamReader(filename);
    }

}
