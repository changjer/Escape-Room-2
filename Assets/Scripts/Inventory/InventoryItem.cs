using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class InventoryItem : MonoBehaviour, IPointerClickHandler
{
    public Inventory inventory;
    public bool ItemRequired;
    public string ItemRequiredName;
    public new string name;
    public string description;
    public Sprite icon;
    public UnityEvent Pass, Fail;

    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {

            if (ItemRequired)
                {
                if (inventory.ActiveItem == ItemRequiredName)
                    {
                    Pass.Invoke();
                    }
                else
                    {
                    Fail.Invoke();
                    return;
                    }
                }
            //Debug.Log("User Selected Item: " + this.gameObject.GetComponent<InventoryItem>().name);
            inventory.gameObject.GetComponent<Inventory>().AddItem(this.gameObject);
            }
        }   
    }
   

