//when clicking on an object with this trigger, will move to the set moveToPos in the CameraMover array and change the ui to have the Back button not the LR buttons
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveTrigger : MonoBehaviour, IPointerClickHandler
    {
    public MoveCamera CameraMover;
    public int moveToPos;
    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {
            if (CameraMover.CurrentIndex != moveToPos)
                {
                var UICG = GameObject.Find("UIButtons").GetComponent<CanvasGroup>();
                var BCG = GameObject.Find("BackButton").GetComponent<CanvasGroup>();
                GameObject.Find("Back").GetComponent<MyGUI>().MoveBackTo = CameraMover.CurrentIndex;
                CameraMover.SnapTo(moveToPos);

                BCG.alpha = 1;
                BCG.interactable = true;
                UICG.alpha = 0;
                UICG.interactable = false;
                }
            else
                {
                //call other trigger functions here to activate while zoomed in
                }
            }
       
        }
    }
