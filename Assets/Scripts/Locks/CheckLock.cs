using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class CheckLock : MonoBehaviour, IPointerClickHandler
    {
    public GameObject[] Cylinders;
    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {

            transform.parent.GetComponent<LockedScript>().CheckCombo();

            transform.parent.GetComponent<LockedScript>().ResetLock();

            }
        }
    }