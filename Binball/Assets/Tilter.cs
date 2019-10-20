using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilter : MonoBehaviour {
    private bool _isTilting = false;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (_isTilting) {
            return;
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.T)) {
            _isTilting = true;
            StartCoroutine(Tilt());
        }
    }

    IEnumerator Tilt() {
        Vector3 startPosition = transform.position;
        int iterations = 10;
        for (int i = 0; i < iterations; i++) {
            Vector3 currentPosition = transform.position;
            transform.position = currentPosition + new Vector3(i / 100.0f, i / 100.0f, 0);
            if (i == iterations - 1) { // last iteration
                transform.position = startPosition;
                _isTilting = false;
            }
            yield return new WaitForSeconds(0.01f);
        }

    }
}