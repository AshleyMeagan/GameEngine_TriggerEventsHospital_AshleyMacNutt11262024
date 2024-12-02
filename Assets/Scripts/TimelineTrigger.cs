using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeline : MonoBehaviour
{
    public PlayableDirector playableDirector; // Reference to the PlayableDirector
    public string triggeringTag = "Player";  // Tag for the triggering object (e.g., Player)

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has the correct tag
        if (other.CompareTag(triggeringTag))
        {
            // Play the Timeline
            if (playableDirector != null)
            {
                playableDirector.Play();
            }
            else
            {
                Debug.LogWarning("PlayableDirector is not assigned!");
            }
        }
    }
}
