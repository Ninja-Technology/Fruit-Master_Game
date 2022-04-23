using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyHoverMenu : MonoBehaviour
{
    public AudioSource mySounds;
    public AudioClip hoverGameStart_Voice;
    public AudioClip hoverInstruction_Voice;
    public AudioClip hoverCredit_Voice;
    public AudioClip hoverQuit_Voice;


    //hover action for buttons
    public void OnTriggerEnter(Collider other)
    {

    }

    //button hover

    public void HoverGameStart()
    {
        mySounds.PlayOneShot(hoverGameStart_Voice);
    }

    public void HoverInstruction()
    {
        //mySounds.PlayOneShot(hoverGameStart_Voice);
    }
    public void HoverCreditVoice()
    {
        //mySounds.PlayOneShot(hoverGameStart_Voice);
    }
    public void HoverQuitGame()
    {
        //mySounds.PlayOneShot(hoverGameStart_Voice);
    }
}
