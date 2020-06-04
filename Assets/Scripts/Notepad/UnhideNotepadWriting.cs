//Reveal the written notepad when clicked on while pencil is in inventory.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using Debug = UnityEngine.Debug;
public class UnhideNotepadWriting : MonoBehaviour, IPointerClickHandler
{
    public GameObject notepadWriting;
    public UnityEvent Reveal, Fail;
    public Inventory inventory;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            //Debug.Log("click notepad");
            //Debug.Log(NW);
            if (inventory.ActiveItem == "Pencil")
            {
                notepadWriting.SetActive(true);
                Reveal.Invoke();
                inventory.RemoveItem(inventory.ActiveItemIndex);
            }
            else
            {
                if (!notepadWriting.activeSelf)
                {
                    Fail.Invoke();
                }
                else
                {
                    Reveal.Invoke();
                }
            }
        }
    }

}