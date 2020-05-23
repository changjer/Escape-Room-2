using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class InventoryItem : MonoBehaviour
{
    public Inventory inventory;
    public bool ItemRequired;
    public string ItemRequiredName;
    public new string name;
    public string description;
    public Sprite icon;
    public UnityEvent Pass, Fail;
    void Start()
    {
       //Print();
    }
    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
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
    public void Print()
    {
        Debug.Log(this.name + "[" + this.description + "] has been created");
    }
}
