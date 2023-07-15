using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if (rb.velocity.magnitude > 3) {
            rb.velocity = rb.velocity.normalized * 3;
        }
    }
}
