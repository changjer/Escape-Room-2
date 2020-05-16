//some code from https://www.youtube.com/watch?v=_nRzoTzeyxU
//DialogueManager holds the functions for the dialogue system

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class DialogueManager : MonoBehaviour
{
    public UnityEvent DialogueBeep;
    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    private bool printing;
    private string sentence;
    private bool isZoomed, isZoomed2;
    void Start()//makes sure that the dialogue box and back button is not on-screen at the start
    {
        sentences = new Queue<string>();
        var DialogueCG = GameObject.Find("DialogueBox").GetComponent<CanvasGroup>();
        var UICG = GameObject.Find("UIButtons").GetComponent<CanvasGroup>();
        var BCG = GameObject.Find("BackButton").GetComponent<CanvasGroup>();
        var BCG2 = GameObject.Find("BackButton2").GetComponent<CanvasGroup>();
        UICG.alpha = 1;
        UICG.interactable = true;
        BCG.alpha = 0;
        BCG.interactable = false;
        BCG2.alpha = 0;
        BCG2.interactable = false; 
        DialogueCG.alpha = 0;
        DialogueCG.interactable = false;
        DialogueCG.blocksRaycasts = false;
        isZoomed = false;
        isZoomed2 = false;
    }

    public void StartDialogue(Dialogue dialogue)//starts a dialogue, bringing up the dialogue box, removing the ui buttons, and calling displaynextsentence
        {
        nameText.text = dialogue.name;
        UnityEngine.Debug.Log(nameText.text);
        sentences.Clear();
        ShowDB();
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
            if (character != ' ')
                {
                DialogueBeep.Invoke();
                }
                dialogueText.text += character;
                for (int i = 0; i < 30; i++)
                    {
                    yield return null;
                    }
                }
            
            printing = false;
        }

    void EndDialogue()//hides dialogue box and brings up ui buttons
        {
        HideDB();
        }

    void HideDB()//hides the dialogue box and checks isZoomed and isZoomed2 to see whether to bring up the LR or Back buttons
        {
        var DialogueCG = GameObject.Find("DialogueBox").GetComponent<CanvasGroup>();
        var UICG = GameObject.Find("UIButtons").GetComponent<CanvasGroup>();
        var BCG = GameObject.Find("BackButton").GetComponent<CanvasGroup>();
        var BCG2 = GameObject.Find("BackButton2").GetComponent<CanvasGroup>();

        if (isZoomed)
            {
            BCG.alpha = 1;
            BCG.interactable = true;
            UICG.alpha = 0;
            UICG.interactable = false;
            DialogueCG.alpha = 0;
            DialogueCG.interactable = false;
            DialogueCG.blocksRaycasts = false;
        }
        else if (isZoomed2)
            {
            BCG2.alpha = 1;
            BCG2.interactable = true;
            UICG.alpha = 0;
            UICG.interactable = false;
            DialogueCG.alpha = 0;
            DialogueCG.interactable = false;
            DialogueCG.blocksRaycasts = false;
        }
        else
            {
            BCG.alpha = 0;
            BCG.interactable = false;
            UICG.alpha = 1;
            UICG.interactable = true;
            DialogueCG.alpha = 0;
            DialogueCG.interactable = false;
            DialogueCG.blocksRaycasts = false;
        }
      
        }

    public void ShowDB()//hides buttons and shows DB, sets isZoomed or isZoomed2 if the back buttons are showing
        {
        var DialogueCG = GameObject.Find("DialogueBox").GetComponent<CanvasGroup>();
        var UICG = GameObject.Find("UIButtons").GetComponent<CanvasGroup>();
        var BCG = GameObject.Find("BackButton").GetComponent<CanvasGroup>();
        var BCG2 = GameObject.Find("BackButton2").GetComponent<CanvasGroup>();

        if (BCG.interactable == true)
            {
            isZoomed = true;
            UICG.alpha = 0;
            UICG.interactable = false;
            BCG.alpha = 0;
            BCG.interactable = false;
            DialogueCG.alpha = 1;
            DialogueCG.interactable = true;
            DialogueCG.blocksRaycasts = true;
        }
        else if (BCG2.interactable==true)
            {
            isZoomed2 = true;
            UICG.alpha = 0;
            UICG.interactable = false;
            BCG2.alpha = 0;
            BCG2.interactable = false;
            DialogueCG.alpha = 1;
            DialogueCG.interactable = true;
            DialogueCG.blocksRaycasts = true;
        }
        else
            {
            isZoomed = false;
            UICG.alpha = 0;
            UICG.interactable = false;
            BCG.alpha = 0;
            BCG.interactable = false;
            DialogueCG.alpha = 1;
            DialogueCG.interactable = true;
            DialogueCG.blocksRaycasts = true;
        }
        }
}
