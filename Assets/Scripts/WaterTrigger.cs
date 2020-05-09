//Checks the name of the object and sets cold or hot on the parent to turn water and steam off and on

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class WaterTrigger : MonoBehaviour, IPointerClickHandler
    {
    
    public void OnPointerClick(PointerEventData eventData)
        {
        if (name == "Cold")
            {
            transform.parent.GetComponent<WaterTriggerParent>().SetCold();
            }
        if (name == "Hot")
            {
            transform.parent.GetComponent<WaterTriggerParent>().SetHot();
            }
        
        }
    
    }