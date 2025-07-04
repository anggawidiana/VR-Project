using UnityEngine;

public class RaycastAudioTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public float maxDistance = 5f;
    private GameObject lastHit;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, maxDistance))
        {
            if (hit.collider.CompareTag("NarrationTarget"))
            {
                if (lastHit != hit.collider.gameObject)
                {
                    audioSource.Play();
                    lastHit = hit.collider.gameObject;
                }
            }
            else
            {
                StopAudio();
            }
        }
        else
        {
            StopAudio();
        }
    }

    void StopAudio()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();

        lastHit = null;
    }
}
