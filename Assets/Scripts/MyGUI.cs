//Contains UI functions, so far moving the camera

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGUI : MonoBehaviour
{
    public MoveCamera CameraMover;
  
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

    }
