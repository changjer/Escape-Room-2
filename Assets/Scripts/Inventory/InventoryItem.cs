using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public Inventory inventory;
    public new string name;
    public string description;
    //public Sprite icon;
    void Start()
    {
       //Print();
    }
    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Debug.Log("User Selected Item: " + this.gameObject.GetComponent<InventoryItem>().name);
            inventory.gameObject.GetComponent<Inventory>().AddItem(this.gameObject); 
        }   
    }
    public void Print()
    {
        Debug.Log(this.name + "[" + this.description + "] has been created");
    }
}
