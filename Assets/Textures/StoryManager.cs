using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{

    Dialogue[] dialogueParts;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateDialogue(string name, string[] sentences, bool isButton, int[] score){
        Dialogue dialogue = new Dialogue();

        dialogue.name = name;
        dialogue.sentences = sentences;
        dialogue.isButton = isButton;
        dialogue.score = score;


        Debug.Log(dialogue.name);
        Debug.Log(dialogue.sentences);
        Debug.Log(dialogue.isButton);
        Debug.Log(dialogue.score);

    }

}
