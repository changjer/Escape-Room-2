using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource CabinetOpen, CabinetClose, Click, Unlock, DoorOpen, DialogueBeep, Rummage, ValveTurn;

    public void playCabinetOpen()
        {
        CabinetOpen.Play();
        }
    public void playCabinetClose()
        {
        CabinetClose.Play();
        }
    public void playClick()
        {
        Click.Play();
        }
    public void playUnlock()
        {
        Unlock.Play();
        }
    public void playDoorOpen()
        {
        DoorOpen.Play();
        }
    public void playDialogueBeep()
        {
        DialogueBeep.Play();
        }
    public void playRummage()
        {
        Rummage.Play();
        }
    public void playValveTurn()
        {
        ValveTurn.Play();
        }
    }
