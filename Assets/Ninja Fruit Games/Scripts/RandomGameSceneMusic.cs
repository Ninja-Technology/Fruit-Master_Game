using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGameSceneMusic : MonoBehaviour
{
    public AudioClip[] clip;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip[Random.Range(0, clip.Length)];
        audioSource.Play();

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
