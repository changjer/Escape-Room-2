//Checks the name of the object and sets cold or hot on the parent to turn water and steam off and on

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class ComputerTrigger : MonoBehaviour, IPointerClickHandler
{
    
    public void OnPointerClick(PointerEventData eventData)
    {
        UnityEngine.Debug.Log("reached");
        var CIF = GameObject.Find("ComputerInputField").GetComponent<CanvasGroup>();
        var BCG = GameObject.Find("BackButton").GetComponent<CanvasGroup>();
        if (BCG.interactable == true)
        {
            CIF.alpha = 1;
            CIF.interactable = true;
        }

    }

}