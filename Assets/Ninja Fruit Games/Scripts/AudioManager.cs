using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{

    public AudioSource sliceSound;
    public AudioSource gunSound;
    public AudioSource musicTheme;
    public AudioSource buttonClickSound;
    public AudioSource countDownVoice;
    public AudioSource gameOver;
    public AudioSource lobbyAudio;

    //added during game mode
    public AudioSource OneHundredPoint;
    public AudioSource TwoHundredPoint;
    public AudioSource ThreeHundredPoint;
    public AudioSource FourHundredPoint;
    public AudioSource FiveHundredPoint;
    public AudioSource kidsCheering;

    //for menu audio hover help
    public AudioSource start;
    public AudioSource instructions;
    public AudioSource credits;
    public AudioSource quit;



    public static AudioManager instance;


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
    }

   
}
