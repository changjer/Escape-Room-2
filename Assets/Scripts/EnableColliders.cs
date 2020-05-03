using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableColliders : MonoBehaviour
{
    public void EnableTaggedColliders()
        {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Zoomable");
        foreach (GameObject obj in objects)
            {
            obj.GetComponent<BoxCollider>().enabled = true;
            }
        }
}
