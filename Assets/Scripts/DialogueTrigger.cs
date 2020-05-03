//This script is added to any object to detect a right click on it and start a dialogue

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueTrigger : MonoBehaviour, IPointerClickHandler
    {
    public Dialogue[] dialogue;
    public int DialogNum;
    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Right)
            {
            TriggerDialogue();
            }
        }

    public void TriggerDialogue()//send to dialogue manager
    {
        if (DialogNum == -1)
            {
            DialogNum = Random.Range(0, dialogue.Length);
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue[DialogNum]);
            DialogNum = -1;
            }
        else
            {

            FindObjectOfType<DialogueManager>().StartDialogue(dialogue[DialogNum]);
            }

        }
    public void SetDialogue(int num)
        {
        DialogNum = num;
        }
}
