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
            transform.position = wayPoint.transform.position;
            yield return new WaitForSeconds(movementDelay);
        }
    }
}
