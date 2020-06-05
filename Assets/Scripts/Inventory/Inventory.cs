using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    public GameObject inventoryPanel;
    public GameObject[] inventorySlot;
    public GameObject[] SelectSlot;
    public GameObject[] CombinedItems;
    public UnityEvent PlayRummage;
    public Sprite Background;
    private Image[] inventoryImage;
    private static int _inventorySize = 6;
    public string ActiveItem;
    public int ActiveItemIndex;
    private bool CheckKey;
    void Start()
    {
        InitializeInventory();
        CheckKey = true;
    }

    public void InitializeInventory()
    {
        inventorySlot = new GameObject[_inventorySize];
        inventoryImage = new Image[_inventorySize];
        ActiveItem = "";
        ActiveItemIndex = -1;
        for(int i = 0; i < _inventorySize; i++)
        {
            inventorySlot[i] = inventoryPanel.transform.GetChild(i).gameObject;
            inventoryImage[i] = inventorySlot[i].transform.GetChild(1).GetComponent<Image>();
            //Debug.Log("Initialize inventorySlot[" + i + "]: " + inventorySlot[i]);
        }
    }
    public bool AddKey()
        {
        string ItemName;
        for (int i = 0; i < inventorySlot.Length; i++)
            {
            if (inventorySlot[i].gameObject.tag == "InventoryItem")
                {
                ItemName = inventorySlot[i].gameObject.GetComponent<InventoryItem>().name;
                if (ItemName == "Key 1" || ItemName == "Key 2" || ItemName == "Key 3" || ItemName == "Key 4")
                    {
                    RemoveItem(i);
                    CheckKey = false;
                    Debug.Log("1");
                    AddItem(CombinedItems[1]);
                    return true;
                    }
                else if (ItemName == "2Keys")
                    {
                    RemoveItem(i);
                    Debug.Log("2");
                    CheckKey = false;
                    AddItem(CombinedItems[2]);
                    return true;
                    }
                else if (ItemName == "3Keys")
                    {
                    RemoveItem(i);
                    CheckKey = false;
                    AddItem(CombinedItems[3]);
                    return true;
                    }
                else
                    {

                    }

                }
            }
        return false;
        }
    public void AddItem(GameObject item)
    {
        bool itemAdded = false;
        
        //find open slot in inventory array
        string ItemName = item.GetComponent<InventoryItem>().name;
        if (CheckKey)
            {
            Debug.Log("3");
            if (ItemName == "Key 1" || ItemName == "Key 2" || ItemName == "Key 3" || ItemName == "Key 4")
                {
                if (AddKey())
                    {
                    item.SetActive(false);
                    return;
                    }
                }
            }
        for(int i = 0; i < inventorySlot.Length; i++)
        {
            //need to check that slot does not contain an item
            if(inventorySlot[i].gameObject.tag != "InventoryItem")
            {
                Debug.Log("4");
                PlayRummage.Invoke();
                var SlotDialogue = inventorySlot[i].GetComponent<DialogueTrigger>();
                SlotDialogue.dialogue = item.GetComponent<DialogueTrigger>().dialogue;
                SlotDialogue.DialogNum = item.GetComponent<DialogueTrigger>().DialogNum;
                inventorySlot[i] = item;
                inventoryImage[i].sprite = item.GetComponent<InventoryItem>().icon;
                item.SetActive(false); //removes item from scene
                //inventorySlot[i]..text = item.GetComponent<Item>().name;
                //Debug.Log(item.name + " was added to inventory");
                itemAdded = true;
                CheckKey = true;
                break;
            }
        }
        if(itemAdded == false)
        {
            //Debug.Log("Inventory Full - Item Not Added");
        }
    }
    public void RemoveItem(int index)
    {

            DeselectItem();
            
        inventorySlot[index] = inventoryPanel.transform.GetChild(index).gameObject;
        inventorySlot[index].GetComponent<DialogueTrigger>().DialogNum = -2;
        inventoryImage[index].sprite = Background;
        PlayRummage.Invoke();
        //Debug.Log("Removing Item");
        }
    public void CombineItems(int index)
        {
        var name1 = inventorySlot[index].GetComponent<InventoryItem>().name;
        var name2 = inventorySlot[ActiveItemIndex].GetComponent<InventoryItem>().name;
        if ((name1 == "Hook" && name2 == "Dowel" )||( name1 == "Dowel" && name2 == "Hook"))
            {
            RemoveItem(ActiveItemIndex);
            RemoveItem(index);
            
           
            AddItem(CombinedItems[0]);
            }
        if ((name1 == "Cloth Scrap 1" && name2 == "Cloth Scrap 2") || (name1 == "Cloth Scrap 2" && name2 == "Cloth Scrap 1"))
            {
            
            RemoveItem(ActiveItemIndex);
            RemoveItem(index);
            AddItem(CombinedItems[4]);
            }
        
        }
    public void SelectItem(int index)
        {
        if (inventorySlot[index].gameObject.tag != "InventoryItem")
            {
            return;
            }
        if (index == ActiveItemIndex)
            {
            DeselectItem();
            return;
            }
        if (ActiveItemIndex != -1)
            {
            CombineItems(index);
            DeselectItem();
            }
        SelectSlot[index].gameObject.SetActive(true);
        ActiveItem = inventorySlot[index].GetComponent<InventoryItem>().name;
        ActiveItemIndex = index;
        }
    public void DeselectItem()
        {
        if (ActiveItemIndex != -1)
            {

            ActiveItem = "";
            SelectSlot[ActiveItemIndex].gameObject.SetActive(false);
            ActiveItemIndex = -1;
            }

        }
    public bool InInventory(string itemName){
        
        for(int i = 0; i < inventorySlot.Length; i++)
        {
            if(inventorySlot[i].gameObject.tag == "InventoryItem" && inventorySlot[i].GetComponent<InventoryItem>().name == itemName)
            {
                return true;
            }
        }
        return false;
    }
}
