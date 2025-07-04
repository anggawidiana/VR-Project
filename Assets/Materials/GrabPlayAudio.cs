using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabPlayAudio : MonoBehaviour
{
    public AudioSource audioSource;

    private void Awake()
    {
        var interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        interactable.selectEntered.AddListener(OnGrab);
        interactable.selectExited.AddListener(OnRelease);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        if (!audioSource.isPlaying)
            audioSource.Play();
    }

    void OnRelease(SelectExitEventArgs args)
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
    }
}
