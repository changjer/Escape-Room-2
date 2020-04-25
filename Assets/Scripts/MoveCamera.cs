//Some code taken from https://answers.unity.com/questions/636489/using-a-button-to-move-the-camera.html
//holds camera positions and sets camera's pos on start
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCamera : MonoBehaviour
{
    public Transform[] Positions;
    public int CurrentIndex;

   void Awake()//set camera to default pos (0) on game start
    {
        SnapTo(0);
    }

    public void SnapTo(int index)//move camera instantly to position defined by index in the Positions array
    {
        Debug.Log("Snapping");
        this.CurrentIndex = index;
        this.transform.position = this.Positions[index].position;
        this.transform.rotation = this.Positions[index].rotation;
    }


}
