using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LobbyHoverMenu : MonoBehaviour
{

    public UnityEvent OnEnter;
    public UnityEvent OnExit;
    public AudioSource audio;


    private void OnTriggerEnter(Collider other)
    {
        TrigExit.instance.currentCollider = GetComponent<LobbyHoverMenu>();

        audio.Play();

        OnEnter.Invoke();
    }


}
