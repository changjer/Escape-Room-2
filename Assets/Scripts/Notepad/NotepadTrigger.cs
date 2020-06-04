//Reveals the hidden notepad writing when clicked on while "
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class NotepadTrigger : MonoBehaviour, IPointerClickHandler
{
    public MoveCamera CameraMover;
    public int moveToPos;

    public void OnPointerClick(PointerEventData eventData)
    { 
        transform.parent.GetComponent<NotepadTriggerParent>().RevealNotepad();
    }

}