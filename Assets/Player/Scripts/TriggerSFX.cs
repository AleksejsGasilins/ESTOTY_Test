using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource playSound;

    void OnTriggerEnter(Collider other)
    {
        playSound.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        playSound.Stop();
    }
}
