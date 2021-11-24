using TMPro;
using UnityEngine;

[ExecuteAlways]
public class CoordinateLabel : MonoBehaviour {

    private TextMeshPro label;

    void Awake() {
        label = GetComponent<TextMeshPro>();
    }
    
    void Update() {
        var gridPosition  = GetCoordinateVector();
        UpdateCoordinateLabel(gridPosition);
        UpdateObjectName(gridPosition);
    }

    private Vector2 GetCoordinateVector() {
        var position = transform.position;
        return new Vector2(position.x / 10, position.z / 10);
    }

    private void UpdateCoordinateLabel(Vector2 gridPosition) {
        if (!Application.isPlaying && label != null) {
            label.text = $"({gridPosition.x}, {gridPosition.y})";
        }    
    }

    private void UpdateObjectName(Vector2 gridPosition) {
        transform.parent.name = $"({gridPosition.x}, {gridPosition.y})";
    }
}
