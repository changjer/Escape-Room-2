using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour {

    [HideInInspector]
    public GameObject LampLight;

    [HideInInspector]
    public GameObject DomeOff;

    [HideInInspector]
    public GameObject DomeOn;

    public bool TurnOn;

    public GameObject inventory;
   
	void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0) && inventory.gameObject.GetComponent<Inventory>().InInventory("Key 3"))
        {
            TurnOn = !TurnOn;
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
