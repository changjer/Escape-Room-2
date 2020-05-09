using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class MoveTumbler : MonoBehaviour, IPointerClickHandler
    {
    public int[] Cylinder, change;
    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {
            for (int i = 0; i < 4; i++)
                {
                if (Cylinder[i] != 0)
                    {
                    transform.parent.GetComponent<LockedScript>().changeCombo(i, change[i]);
                    }
                
                
                }
            
            }
        }
    }