using UnityEngine;


public class HoverAudio : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        var interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        interactable.hoverEntered.AddListener((_) => audioSource.Play());
        interactable.hoverExited.AddListener((_) => audioSource.Stop());
    }
}
