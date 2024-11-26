using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Play the sound
            if (audioSource != null) // Ensure that the audioSource is assigned
            {
                audioSource.Play();
            }
            else
            {
                Debug.LogError("AudioSource is not assigned in the Inspector!");
            }
        }
    }
}
