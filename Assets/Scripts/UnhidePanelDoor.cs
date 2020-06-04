//Unhide the panel door to reveal Key 1d. 
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.Events;
public class UnhidePanelDoor : MonoBehaviour
{
    public GameObject userInput;
    //public GameObject verificationMessage;
    private string enteredPW;
    // public string wrongPasswordMessage;
    // public string correctPasswordMessage;
    public UnityEvent Pass;
    bool unhideOnce = false;

    public void Unhide(GameObject obj)
    {
        enteredPW = userInput.GetComponent<Text>().text;
        //Debug.Log(enteredPW);
        if (unhideOnce == false)
        {
            if (enteredPW == "5418")
            {
                obj.SetActive(true);
                unhideOnce = true;
                Pass.Invoke();
            }
        }


    }

}
