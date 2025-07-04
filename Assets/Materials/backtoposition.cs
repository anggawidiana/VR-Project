using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;

[RequireComponent(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable))]
[RequireComponent(typeof(Rigidbody))]
public class ReturnToStartPosition : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private Rigidbody rb;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;
    private Collider[] allColliders;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable.MovementType originalMovementType;

    void Awake()
    {
        // Ambil referensi komponen
        rb = GetComponent<Rigidbody>();
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        allColliders = GetComponentsInChildren<Collider>();

        // Simpan posisi & rotasi awal
        initialPosition = transform.position;
        initialRotation = transform.rotation;

        // Simpan movement type awal
        originalMovementType = grabInteractable.movementType;

        // Tambahkan event
        grabInteractable.selectEntered.AddListener(OnSelectEnter);
        grabInteractable.selectExited.AddListener(OnSelectExit);
    }

    void OnDestroy()
    {
        grabInteractable.selectEntered.RemoveListener(OnSelectEnter);
        grabInteractable.selectExited.RemoveListener(OnSelectExit);
    }

    private void OnSelectEnter(SelectEnterEventArgs args)
    {
        // Ubah movement type ke Kinematic
        grabInteractable.movementType = UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable.MovementType.Kinematic;

        // Nonaktifkan collider agar tidak tabrakan
        foreach (var col in allColliders)
        {
            col.enabled = false;
        }
    }

    private void OnSelectExit(SelectExitEventArgs args)
    {
        // Matikan physics sementara
        rb.isKinematic = true;

        // Reset posisi & rotasi
        transform.position = initialPosition;
        transform.rotation = initialRotation;

        // Kembalikan movement type awal (jika perlu)
        grabInteractable.movementType = originalMovementType;

        // Aktifkan kembali collider dan physics setelah delay
        StartCoroutine(ReenableColliderAndPhysics());
    }

    private IEnumerator ReenableColliderAndPhysics()
    {
        yield return new WaitForSeconds(0.1f);

        // Aktifkan collider kembali
        foreach (var col in allColliders)
        {
            col.enabled = true;
        }

        // Aktifkan physics kembali
        rb.isKinematic = false;
    }
}
