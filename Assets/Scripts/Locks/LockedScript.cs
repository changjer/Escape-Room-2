//contains functions for changing, checking, and reseting a combination lock


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class LockedScript : MonoBehaviour
{
    public int[] combination,key;
    public UnityEvent Unlock, Reset;
    public GameObject[] Cylinders;
    public GameObject dialogue;
    

    public void changeCombo(int slot, int change)//moves the cylinders and changes the value of the combination
        {
      
        combination[slot] += change*-1;
        if (combination[slot] == -1)
            {
            combination[slot] = 9;
            }
        if (combination[slot] == 10)
            {
            combination[slot] = 0;
            }
        Cylinders[slot].transform.localEulerAngles += new Vector3(0,36*change*-1,0);
        
        }
    public void CheckCombo()//checks the combination to see if it is correct and calls the unlock event and plays dialogue if it is
        {
        for (int i = 0; i < 4; i++)
            {
            if (combination[i] != key[i])
                {
                return;
                }
            }
        dialogue.GetComponent<DialogueTrigger>().TriggerDialogue();
        Unlock.Invoke();
        }
    public void ResetLock()//resets the cylinders and the combination to 0
        {
        Reset.Invoke();
        foreach (GameObject cylinder in Cylinders)
            {
            cylinder.transform.localEulerAngles = new Vector3(90, 0, 0);

            }
        for (int i = 0; i < combination.Length; i++)
            {
            combination[i] = 0;
            }
        }
    }
