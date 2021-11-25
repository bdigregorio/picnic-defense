using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathManager : MonoBehaviour {
    [SerializeField] float movementDelay = 1f;
    [SerializeField] List<WayPoint> path = new List<WayPoint>();

    void Start() {
        StartCoroutine(nameof(FollowPath));
    }

    IEnumerator FollowPath() {
        foreach (var wayPoint in path) {
            Vector3 startPosition = transform.position;
            Vector3 endPosition = wayPoint.transform.position;
            float travelPercent = 0;

            while (travelPercent < 1f) {
                travelPercent += Time.deltaTime;
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
