//This script is added to any object to detect a right click on it and start a dialogue

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    void OnMouseOver()//detect click
    {
        if (Input.GetMouseButtonDown(1))//1 is right click
        {
            TriggerDialogue();
        }
    }

    public void TriggerDialogue()//send to dialogue manager
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    
    }
}
