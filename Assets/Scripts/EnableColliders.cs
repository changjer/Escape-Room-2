//Reenables box colliders when called in camera moving scripts like moveTrigger, allows flexiblity with box colliders in other box colliders

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableColliders : MonoBehaviour
{
    public void EnableTaggedColliders()//used for single zoom
        {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Zoomable");
        foreach (GameObject obj in objects)
            {
            obj.GetComponent<BoxCollider>().enabled = true;
            }
        }

    public void EnableTaggedColliders2()//used for "double zoom"
        {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Zoomable2");
        foreach (GameObject obj in objects)
            {
            obj.GetComponent<BoxCollider>().enabled = true;
            }
        }
    }
