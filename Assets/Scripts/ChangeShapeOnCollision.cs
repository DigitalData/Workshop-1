using UnityEngine;

public class ChangeShapeOnCollision : MonoBehaviour
{
    // [SerializeField]
    // private GameObject startOn;
    [SerializeField]
    private Mesh changeTo;

    private void OnCollisionEnter()
    {
        // Change the shape
        MeshFilter meshFilter = this.gameObject.GetComponent<MeshFilter>();
        meshFilter.mesh = changeTo;
    }
}
