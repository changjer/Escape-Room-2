using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class KeyTrigger : MonoBehaviour, IPointerClickHandler
    {
    public Inventory Inventory;
    public GameObject[] Keys;
    public GameObject[] InitialPos;
    public GameObject[] FinalPos;
    public int[] Combination;
    private int CurrentKey;
    public UnityEvent Pass;
    public int[] Code1;
    public int[] Code2;
    public int[] Code3;
    void Start()
        {
        CurrentKey = 0;
        }
    public void OnPointerClick(PointerEventData eventData)
        {
        if (eventData.button == PointerEventData.InputButton.Left)
            {

            if (Inventory.ActiveItem == "4Keys")
                {
                for (int i = 0; i < 4; i++)
                    {
                    Keys[i].SetActive(true);
                    }
                Inventory.RemoveItem(Inventory.ActiveItemIndex);
                }
            }
        
        }

    public void ResetKeys()
        {
        for (int i = 0; i < 4; i++)
            {
            Keys[i].transform.localPosition = InitialPos[i].transform.localPosition;
            Keys[i].transform.localRotation = InitialPos[i].transform.localRotation;
            }
        }
    
    public void RemoveKey(int index,int place)
        {
        Keys[index].transform.localPosition = InitialPos[index].transform.localPosition;
        Combination[place] = -1;
        
        }
    public int AddKey(int index)
        {
        for (int i = 0; i < 4; i++)
            {
            if (Combination[i] == -1)
                {
                CurrentKey = i;
                break;
                }
            }
        Keys[index].transform.localPosition = FinalPos[CurrentKey].transform.localPosition;
        Combination[CurrentKey] = index;
       

            CheckKey(Code1);
            CheckKey(Code2);
            CheckKey(Code3);

        return CurrentKey;
        }
    public void CheckKey(int[] code)
        {
        
         
        for (int i = 0; i < 4; i++)
            {
            if (Combination[i] != code[i])
                {
                return;
                }
            }
        Debug.Log("Pass");
        Pass.Invoke();
        }
    }


