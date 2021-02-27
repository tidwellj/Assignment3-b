using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    void Jump()
    {
        audioSource.PlayOneShot(clip, volume);
    }
}
