//put onto a box collider to use changeCombo on click
//create a puzzle lock by setting multiple values in Cylinder to 1 to change more than one at once
//IMPORTANT: change is positive for up on the tumbler (lower value) and negative for down (higher value)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class MoveTumbler : MonoBehaviour, IPointerClickHandler
    {
    public int[] Cylinder, change;
    public UnityEvent turn;
    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {
            for (int i = 0; i < 4; i++)
                {
                if (Cylinder[i] != 0)
                    {
                    transform.parent.GetComponent<LockedScript>().changeCombo(i, change[i]);
                    turn.Invoke();
                    }
                
                
                }
            
            }
        }
    }