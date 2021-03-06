﻿//when clicking on an object with this trigger, will move to the set moveToPos in the CameraMover array and change the ui to have the Back button not the LR buttons
//this function is used after MoveTrigger when already zoomed
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class MoveTrigger2 : MonoBehaviour, IPointerClickHandler
    {
    public MoveCamera CameraMover;

    public int moveToPos;
    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {
            if (CameraMover.CurrentIndex != moveToPos)
                {
                var BCG = GameObject.Find("BackButton").GetComponent<CanvasGroup>();
                var BCG2 = GameObject.Find("BackButton2").GetComponent<CanvasGroup>();
                var CIF = GameObject.Find("ComputerInputField").GetComponent<CanvasGroup>();
                var NP = GameObject.Find("Notepad").GetComponent<BoxCollider>();


                GameObject.Find("Back2").GetComponent<MyGUI>().MoveBackTo2 = CameraMover.CurrentIndex;

                CameraMover.SnapTo(moveToPos);

                BCG2.alpha = 1;
                BCG2.interactable = true;
                BCG2.blocksRaycasts = true;
                BCG.alpha = 0;
                BCG.interactable = false;
                GameObject.Find("_GM").GetComponent<EnableColliders>().EnableTaggedColliders2();
                GetComponent<BoxCollider>().enabled = false;
                CIF.alpha = 0;
                CIF.interactable = false;
                CIF.blocksRaycasts = false;
                GameObject.Find("Notepad").GetComponent<BoxCollider>().enabled = true;

            }
            else
                {
                //do nothing
                }
            }

        }
    }
