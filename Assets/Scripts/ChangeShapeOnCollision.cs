using UnityEngine;

public class ChangeShapeOnCollision : MonoBehaviour
{
    // [SerializeField]
    // private GameObject startOn;
    [SerializeField]
    private Mesh changeTo;

    void Start()
    {
        changeTo = Resources.GetBuiltinResource<Mesh>("Sphere.fbx");
    }

    private void OnCollisionEnter()
    {
        Debug.Log("woa");

        // Change the shape
        MeshFilter meshFilter = this.gameObject.GetComponent(typeof(MeshFilter)) as MeshFilter;
        meshFilter.mesh = changeTo;
    }
}
