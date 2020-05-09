//Contains UI functions, so far moving the camera

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGUI : MonoBehaviour
{
    public MoveCamera CameraMover;
    public int MoveBackTo;
    public int MoveBackTo2;
    public void moveLeft()//iterates the camera left in the main room
    {
        
        if (CameraMover.CurrentIndex <= 3)
            {
            
            if (CameraMover.CurrentIndex < 3)
                {
            
                CameraMover.SnapTo(CameraMover.CurrentIndex + 1);
                }
            else
                {
                CameraMover.SnapTo(0);
                }
            }
        else
            {
            if (CameraMover.CurrentIndex < 7)
                {
                CameraMover.SnapTo(CameraMover.CurrentIndex + 1);
                }
            else
                {
                CameraMover.SnapTo(4);
                }


            }
    }
    public void moveRight()//iterates the camera right in the main room
        {
        if (CameraMover.CurrentIndex <= 3)
            {
            if (CameraMover.CurrentIndex != 0)
                {
                CameraMover.SnapTo(CameraMover.CurrentIndex - 1);
                }
            else
                {
                CameraMover.SnapTo(3);
                }
            }
        else
            {
            if (CameraMover.CurrentIndex != 4)
                {
                CameraMover.SnapTo(CameraMover.CurrentIndex - 1);
                }
            else
                {
                CameraMover.SnapTo(7);
                }
            }
        }
    public void moveBack()//sets UI to normal and moves camera back to where it was before moveTrigger was activated, only called after moveTrigger
        {
        CameraMover.SnapTo(MoveBackTo);
        MoveBackTo = -1;
        GameObject.Find("_GM").GetComponent<EnableColliders>().EnableTaggedColliders();
        var UICG = GameObject.Find("UIButtons").GetComponent<CanvasGroup>();
        var BCG = GameObject.Find("BackButton").GetComponent<CanvasGroup>();
        UICG.alpha = 1;
        UICG.interactable = true;
        BCG.alpha = 0;
        BCG.interactable = false;
        }

    public void moveBack2()//moves from double zoom to single zoom, keeping previous moveBackto values
        {
        CameraMover.SnapTo(MoveBackTo2);

        GameObject.Find("_GM").GetComponent<EnableColliders>().EnableTaggedColliders2();
        var BCG2 = GameObject.Find("BackButton2").GetComponent<CanvasGroup>();
        var BCG = GameObject.Find("BackButton").GetComponent<CanvasGroup>();
        BCG.alpha = 1;
        BCG.interactable = true;
        BCG2.alpha = 0;
        BCG2.interactable = false;
        BCG2.blocksRaycasts = false;
        }
    }
