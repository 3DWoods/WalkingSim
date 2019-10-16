using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{

    public float audioFrequency;
    public bool setRandomAudioFreq;
    public float audioFrequencyMin, audioFrequencyMax;
    public AudioClip[] avaliableSounds;
    public float elapsedTime;
    private AudioSource audioSource;
    public AudioListener[] al;

    // Start is called before the first frame update
    void Start()
    {
        audioFrequencyMin = audioFrequency;
        if (setRandomAudioFreq) audioFrequency = Random.Range(audioFrequencyMin, audioFrequencyMax);
        elapsedTime = Random.Range(0, audioFrequency);
        audioSource = GetComponent<AudioSource>();
        al = FindObjectsOfType<AudioListener>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayAudio();
    }

    void PlayAudio()
    {
        if (!audioSource.isPlaying)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {
            elapsedTime = 0;
        }

        if (elapsedTime > audioFrequency)
        {
            int clip = Random.Range(0, avaliableSounds.Length);
            audioSource.clip = avaliableSounds[clip];
            audioSource.Play();
            audioFrequency = Random.Range(audioFrequencyMin, audioFrequencyMax);
        }

    }
}
