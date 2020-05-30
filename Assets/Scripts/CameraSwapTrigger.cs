//moves the camera from loop to loop via clicking on the bathroom door
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class CameraSwapTrigger : MonoBehaviour, IPointerClickHandler
{
    public MoveCamera CameraMover;
    public GameObject Dk;
    public UnityEvent RoomChange,Unlock,Fail;
    public Inventory inventory;
    private bool DoorOpen = false;
    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {
            if (DoorOpen)
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
            else
                {
                if (inventory.ActiveItem == "Door Knob")
                    {
                    DoorOpen = true;
                    Dk.SetActive(true);
                    Unlock.Invoke();
                    inventory.RemoveItem(inventory.ActiveItemIndex);
                    }
                else
                    {
                    Fail.Invoke();
                    }
                }
            }
        }

}
