using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ExitDoor : MonoBehaviour, IPointerClickHandler
{
    public GameObject UI, EndScreen,timer;
    public Text text;
    

    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {
            UI.SetActive(false);
            EndScreen.SetActive(true);
            text.text += timer.GetComponent<Text>().text;
            text.text += " left on the clock!";
            }
        }
}
