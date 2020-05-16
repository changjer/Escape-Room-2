//moves the camera from loop to loop via clicking on the bathroom door
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class CameraSwapTrigger : MonoBehaviour, IPointerClickHandler
{
    public MoveCamera CameraMover;
    public UnityEvent RoomChange;
    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {
            RoomChange.Invoke();
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
