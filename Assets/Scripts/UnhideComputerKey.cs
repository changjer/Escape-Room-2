//Unlock Key 1 (Computer Key) when correct password is entered. 
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class UnhideComputerKey : MonoBehaviour
{
    public GameObject userInput;
    public GameObject verificationMessage;
    private string enteredPW;
    public string wrongPasswordMessage;
    public string correctPasswordMessage;

    bool unhideOnce = false;
    
    public void Unhide(GameObject obj)
    {
        //GameObject go = GameObject.Find("Panel Door");
        //var pd = GameObject.Find("Panel Door");
        enteredPW = userInput.GetComponent<Text>().text;
        //Debug.Log(enteredPW);
        if (unhideOnce == false)
        {
            if (enteredPW == "5418")
            {
                obj.SetActive(true);
                //pd.SetActive(true);
                //go.SetActive(true);
                unhideOnce = true;
                verificationMessage.GetComponent<Text>().text = correctPasswordMessage;
            }
             else
             {
                verificationMessage.GetComponent<Text>().text = wrongPasswordMessage;
             }
        }
       
        
    }

}
