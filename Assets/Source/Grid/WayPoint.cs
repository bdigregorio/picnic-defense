using UnityEngine;
using UnityEngine.Serialization;

public class WayPoint : MonoBehaviour {
    [SerializeField] bool isBuildable;

    private void OnMouseDown() {
        if (isBuildable) {
            Debug.Log($"Clicked: {transform.name}");
        }
    }
}
