using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWalkPlayer : MonoBehaviour
{
   
    public Rigidbody targetObject;  // The object you want to track movement on
    public AudioSource audioSource; // The sound that will play when the object moves
    public float volume = 0.2f;     // Volume control (0 is silent, 1 is full volume)

    private bool isPlayingSound = false; // To check if the sound is already playing

    void Start()
    {
        // Set the initial volume of the audio source
        audioSource.volume = volume;
    }

    void Update()
    {
        // Check if the object is moving
        if (targetObject.velocity.magnitude > 0.1f)
        {
            // If it's moving and the sound isn't already playing, start the sound
            if (!isPlayingSound)
            {
                audioSource.Play();
                isPlayingSound = true;
            }
        }
        else
        {
            // If the object stopped moving and the sound is still playing, stop the sound
            if (isPlayingSound)
            {
                audioSource.Stop();
                isPlayingSound = false;
            }
        }
    }
}
