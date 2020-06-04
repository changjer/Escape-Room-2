using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Lamp : MonoBehaviour {

    [HideInInspector]
    public GameObject LampLight;

    [HideInInspector]
    public GameObject DomeOff;

    [HideInInspector]
    public GameObject DomeOn;

    public bool TurnOn;
    public UnityEvent On;
    public Inventory inventory;
   
	void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0) && inventory.ActiveItem=="Light Bulb")
        {

            TurnOn = !TurnOn;
       
                On.Invoke();
   
            inventory.RemoveItem(inventory.ActiveItemIndex);
        }
    }
	// Update is called once per frame
	void Update () {

        if (TurnOn== true)
        {
            LampLight.SetActive(true);
            DomeOff.SetActive(false);
            DomeOn.SetActive(true);

        }
        if (TurnOn == false)
        {
            LampLight.SetActive(false);
            DomeOff.SetActive(true);
            DomeOn.SetActive(false);

        }
    }
}
