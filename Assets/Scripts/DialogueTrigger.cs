//This script is added to any object to detect a right click on it and start a dialogue

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueTrigger : MonoBehaviour, IPointerClickHandler
    {
    public Dialogue dialogue;

    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Right)//1 is right click
            {
            TriggerDialogue();
            }
        }

    public void TriggerDialogue()//send to dialogue manager
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    
    }
}
