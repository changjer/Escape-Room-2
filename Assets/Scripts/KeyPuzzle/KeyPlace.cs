using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class KeyPlace: MonoBehaviour, IPointerClickHandler
{
    public bool isSet;
    public int KeyNum;
    public KeyTrigger Keytrigger;
    private int place;
    void Start()
        {
        place = 0;
        }
    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {
            if (isSet)
                {
                Keytrigger.RemoveKey(KeyNum,place);
                }
            else
                {
                place = Keytrigger.AddKey(KeyNum);
                }
            isSet = !isSet;
            }
        }
}
