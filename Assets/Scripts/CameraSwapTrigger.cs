﻿//moves the camera from loop to loop via clicking on the bathroom door
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraSwapTrigger : MonoBehaviour, IPointerClickHandler
{
    public MoveCamera CameraMover;

    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {

            if (CameraMover.CurrentIndex >= 0 && CameraMover.CurrentIndex <= 3)
                {
                CameraMover.SnapTo(4);
                }
            else
                {
                CameraMover.SnapTo(0);
                }
            }
        }

}
