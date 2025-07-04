using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshCollider))]
public class CombineMeshesAtRuntime : MonoBehaviour
{
    void Start()
    {
        MeshFilter[] meshFilters = GetComponentsInChildren<MeshFilter>();
        CombineInstance[] combine = new CombineInstance[meshFilters.Length];

        for (int i = 0; i < meshFilters.Length; i++)
        {
            combine[i].mesh = meshFilters[i].sharedMesh;
            combine[i].transform = meshFilters[i].transform.localToWorldMatrix;
        }

        Mesh combinedMesh = new Mesh();
        combinedMesh.CombineMeshes(combine);

        GetComponent<MeshFilter>().sharedMesh = combinedMesh;
        GetComponent<MeshCollider>().sharedMesh = combinedMesh;
    }
}
