using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class WaterTriggerParent : MonoBehaviour
    {
    public bool Hot, Cold;
    public UnityEvent ColdWater;
    public UnityEvent Water;
    public UnityEvent HotWater;
    public UnityEvent NoWater;
    void Start()
        {
        Hot = false;
        Cold = false;
        }
    public void SetHot()
        {
        Hot = !Hot;
        SetEffects();
        }
    public void SetCold()
        {
        Cold = !Cold;
        SetEffects();
        }
    public void SetEffects()
        {
        if (Cold && !Hot)
            {
            ColdWater.Invoke();
            }
        if (Cold && Hot)
            {
            Water.Invoke();
            }
        if (Hot && !Cold)
            {
            HotWater.Invoke();
            }
        if (!Cold && !Hot)
            {
            NoWater.Invoke();
            }
        }
    }