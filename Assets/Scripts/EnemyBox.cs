﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBox : MonoBehaviour {
    public GameObject prefab;
    Coroutine routine = null;
    // Start is called before the first frame update
    void Start() {
        routine = StartCoroutine(CreateEnemy());
    }
    IEnumerator CreateEnemy() {
        while (true) {
            yield return new WaitForSeconds(1.0f);
            Instantiate(
                prefab,
                new Vector3(Random.Range(-10, 11), 1f, 15f),
                Quaternion.identity
                );
        }
    }
    public void Stop() {
        StopCoroutine(routine);
        Time.timeScale = 0f;
    }
}