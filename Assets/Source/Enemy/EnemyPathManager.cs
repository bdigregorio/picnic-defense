using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathManager : MonoBehaviour {
    [SerializeField] List<WayPoint> path = new List<WayPoint>();

    void Start() {
        foreach (var wayPoint in path) {
            Debug.Log(wayPoint.name);
        }
    }
}
