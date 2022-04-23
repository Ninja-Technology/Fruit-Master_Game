using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelaySound : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //AudioManager.instance.buttonClickSound.gameObject.transform.position = transform.position;
        //AudioManager.instance.buttonClickSound.Play();

        AudioManager.instance.welcomeAndInstructionVoice.gameObject.transform.position = transform.position;
        AudioManager.instance.welcomeAndInstructionVoice.PlayDelayed(8);
    }


}
