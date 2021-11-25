using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathManager : MonoBehaviour {
    [SerializeField] [Range(0f, 5f)] float speed = 1f;
    [SerializeField] List<WayPoint> path = new List<WayPoint>();

    void Start() {
        StartCoroutine(nameof(FollowPath));
    }

    IEnumerator FollowPath() {
        foreach (var wayPoint in path) {
            Vector3 startPosition = transform.position;
            Vector3 endPosition = wayPoint.transform.position;
            float travelPercent = 0;
            
            transform.LookAt(endPosition);

            while (travelPercent < 1f) {
                travelPercent += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
