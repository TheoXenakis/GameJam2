using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAudioPlayer : MonoBehaviour
{
    public Transform player;        // The player or object to move
    public Transform targetPoint;   // The point to reach
    public AudioSource audioSource; // The sound to play when reaching the point
    public float distanceThreshold = 1.0f; // Distance to trigger the sound

    private bool soundPlayed = false; // Ensures sound plays only once

    void Start()
    {
        // Make sure the audio doesn't play at the start
        audioSource.Stop();
    }

    void Update()
    {
        // Calculate distance between the player and the target point
        float distance = Vector3.Distance(player.position, targetPoint.position);

        // If player is close enough to the target and the sound hasn't been played yet
        if (distance <= distanceThreshold && !soundPlayed)
        {
            audioSource.Play();  // Play the sound
            soundPlayed = true;  // Set to true to ensure sound only plays once
        }
    }
}