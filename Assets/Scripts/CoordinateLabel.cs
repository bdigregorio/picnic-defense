using TMPro;
using UnityEngine;

[ExecuteAlways]
public class CoordinateLabel : MonoBehaviour {

    private TextMeshPro label;

    void Awake() {
        label = GetComponent<TextMeshPro>();
    }
    
    void Update() {
        UpdateCoordinateLabel();
    }

    private void UpdateCoordinateLabel() {
        if (!Application.isPlaying) {
            if (label == null) return;
            var position = transform.position;
            var xPos = position.x / 10;
            var zPos = position.z / 10;
            label.text = $"({xPos}, {zPos})";
        }    
    }
}
