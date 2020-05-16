//Computer input fields show up when clicked in zoomed view.  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class ComputerTrigger : MonoBehaviour, IPointerClickHandler
{
    
    public void OnPointerClick(PointerEventData eventData)
    {
        var CIF = GameObject.Find("ComputerInputField").GetComponent<CanvasGroup>();
        var BCG = GameObject.Find("BackButton").GetComponent<CanvasGroup>();
        if (BCG.interactable == true)
        {
            CIF.alpha = 1;
            CIF.interactable = true;
            CIF.blocksRaycasts = true;
        }

    }

}