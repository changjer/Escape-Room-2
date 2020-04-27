using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    public GameObject inventoryPanel;
    public GameObject[] inventorySlot;
    private static int _inventorySize = 6;

    void Start()
    {
        InitializeInventory();
    }

    public void InitializeInventory()
    {
        inventorySlot = new GameObject[_inventorySize];
        
        for(int i = 0; i < _inventorySize; i++)
        {
            inventorySlot[i] = inventoryPanel.transform.GetChild(i).gameObject;
            Debug.Log("Initialize inventorySlot[" + i + "]: " + inventorySlot[i]);
        }
    }
    public void AddItem(GameObject item)
    {
        bool itemAdded = false;
        //find open slot in inventory array
        for(int i = 0; i < inventorySlot.Length; i++)
        {
            //need to check that slot does not contain an item
            if(inventorySlot[i].gameObject.tag != "InventoryItem")
            {   
                inventorySlot[i] = item;
                item.SetActive(false); //removes item from scene
                //inventorySlot[i]..text = item.GetComponent<Item>().name;
                Debug.Log(item.name + " was added to inventory");
                itemAdded = true;
                break;
            }
        }
        if(itemAdded == false)
        {
            Debug.Log("Inventory Full - Item Not Added");
        }
    }
    public void RemoveItem(int index)
    {
        inventorySlot[index].gameObject.SetActive(true);
        inventorySlot[index] = inventoryPanel.transform.GetChild(index).gameObject;
        Debug.Log("Removing Item");
    }
}
