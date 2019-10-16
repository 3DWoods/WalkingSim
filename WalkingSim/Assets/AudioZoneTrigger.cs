using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioZoneTrigger : MonoBehaviour
{

    private AudioReverbZone zone;

    private void Start()
    {
        zone = GetComponent<AudioReverbZone>();
        zone.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            zone.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            zone.enabled = false;
        }
    }


}
