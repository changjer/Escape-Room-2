﻿//This script is added to any object to detect a right click on it and start a dialogue

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using Debug = UnityEngine.Debug;

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
        if (DialogNum == -2)
            {
            return;
            }
        if (DialogNum == -1)//random flag to select any dialogue from the array
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
    public void SetDialogue(int num)//can be access via event to change what dialogue will be said
        {
        DialogNum = num;
        }
}
