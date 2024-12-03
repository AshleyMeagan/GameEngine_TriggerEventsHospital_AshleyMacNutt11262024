using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{
    public PlayableDirector playableDirector;  // Reference to the PlayableDirector
    public string triggeringTag = "Player";   // Tag to identify the triggering object

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggeringTag))  // Check if the object has the correct tag
        {
            if (playableDirector != null)
            {
                playableDirector.Play();  // Play the timeline
            }
            else
            {
                Debug.LogWarning("PlayableDirector is not assigned!");
            }
        }
    }
}
