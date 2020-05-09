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

    public void EnableTaggedColliders2()
        {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Zoomable2");
        foreach (GameObject obj in objects)
            {
            obj.GetComponent<BoxCollider>().enabled = true;
            }
        }
    }
