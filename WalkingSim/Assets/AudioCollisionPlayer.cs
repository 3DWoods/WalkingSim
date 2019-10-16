using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollisionPlayer : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip[] avaliableSounds;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void TriggerAudio()
    {
        int clip = Random.Range(0, avaliableSounds.Length);
        audioSource.clip = avaliableSounds[clip];
        audioSource.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            TriggerAudio();
        }
    }

}
