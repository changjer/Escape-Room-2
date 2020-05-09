using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ChangePos : MonoBehaviour, IPointerClickHandler
    {
    Vector3 InitPos, InitRot;
    public Vector3 ToPos,ToRot;

    bool Set;
    void Start()
        {
        InitPos = transform.localPosition;
        InitRot = transform.localRotation.eulerAngles;
      
        
        Set = true;
        
        }

    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {
            SwapPos();
            }
        }

        public void SwapPos ()
        {
        if (Set)
            {

            transform.localPosition = ToPos;
            transform.localRotation = Quaternion.Euler(ToRot);
            Set = false;
            }
        else
            {
            transform.localPosition = InitPos;
            transform.localRotation = Quaternion.Euler(InitRot);
            Set = true;
            }
        }
}
