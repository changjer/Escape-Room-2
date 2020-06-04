//Functions for triggers on the notepad.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class NotepadTriggerParent : MonoBehaviour
{
    public UnityEvent Reveal;
   
    public void RevealNotepad()
    {
        Reveal.Invoke();
    }

}