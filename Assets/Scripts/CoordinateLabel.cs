using TMPro;
using UnityEngine;

[ExecuteAlways]
public class CoordinateLabel : MonoBehaviour {

    private TextMeshPro label;
    private Vector2Int gridPosition;

    void Awake() {
        label = GetComponent<TextMeshPro>();
        UpdateCoordinateLabel();
    }
    
    void Update() {
        if (!Application.isPlaying) {
            UpdateCoordinateLabel();
        }
    }

    private Vector2Int GetGridPosition() {
        var position = transform.parent.position;
        var gridUnitSize = UnityEditor.EditorSnapSettings.move;
        var x = Mathf.RoundToInt(position.x / gridUnitSize.x);
        var y = Mathf.RoundToInt(position.z / gridUnitSize.z);
        return new Vector2Int(x, y);
    }

    private void UpdateCoordinateLabel() {
        gridPosition  = GetGridPosition();
        if (label != null) {
            label.text = $"({gridPosition.x}, {gridPosition.y})";
        }    
        UpdateObjectName();
    }

    private void UpdateObjectName() {
        transform.parent.name = $"({gridPosition.x}, {gridPosition.y})";
    }
}
