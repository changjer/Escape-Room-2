//some code from https://www.youtube.com/watch?v=_nRzoTzeyxU
//DialogueManager holds the functions for the dialogue system

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    private bool printing;
    private string sentence;
    void Start()//makes sure that the dialogue box is not on-screen at the start
    {
        sentences = new Queue<string>();
        var DialogueCG = GameObject.Find("DialogueBox").GetComponent<CanvasGroup>();
        var UICG = GameObject.Find("UIButtons").GetComponent<CanvasGroup>();

        UICG.alpha=1;
        UICG.interactable=true;
        DialogueCG.alpha=0;
        DialogueCG.interactable=false;
    }

    public void StartDialogue(Dialogue dialogue)//starts a dialogue, bringing up the dialogue box, removing the ui buttons, and calling displaynextsentence
        {
        nameText.text = dialogue.name;

        sentences.Clear();
        var DialogueCG = GameObject.Find("DialogueBox").GetComponent<CanvasGroup>();
        var UICG = GameObject.Find("UIButtons").GetComponent<CanvasGroup>();

        UICG.alpha = 0;
        UICG.interactable = false;
        DialogueCG.alpha = 1;
        DialogueCG.interactable = true;
        foreach (string sentence in dialogue.sentences)
            {
            sentences.Enqueue(sentence);
            }

        DisplayNextSentence();

        }
    public void DisplayNextSentence()//checks if the TypeDialogue coroutine is running and either starts it with the next sentence or ends it and displays the full sentence
        {
        if (printing == false)
            {

            if (sentences.Count == 0)
                {
                EndDialogue();
                return;
                }
            sentence = sentences.Dequeue();

            StartCoroutine(TypeDialogue(sentence));
            }
        else
            {
            StopAllCoroutines();
            printing = false;
            dialogueText.text = sentence;
            }
        }

    IEnumerator TypeDialogue(string phrase)//coroutine to print out the text letter by letter
        {
        printing = true;
            dialogueText.text = "";
            foreach (char character in phrase.ToCharArray())
                {
                dialogueText.text += character;
                for (int i = 0; i < 50; i++)
                    {
                    yield return null;
                    }
                }
            
            printing = false;
        }

    void EndDialogue()//hides dialogue box and brings up ui buttons
        {
        var DialogueCG = GameObject.Find("DialogueBox").GetComponent<CanvasGroup>();
        var UICG = GameObject.Find("UIButtons").GetComponent<CanvasGroup>();
        
        UICG.alpha=1;
        UICG.interactable=true;
        DialogueCG.alpha=0;
        DialogueCG.interactable=false;

        }

}
