using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (-3, -2);
    }

    private void Update() {
        rb.velocity = rb.velocity.normalized * 4;
    }

    public void ResetBall() {
        transform.position = Vector2.zero;

        float x = Random.Range(-3, 3);
        float y = Random.Range(-3, 3);

        if (x > -.5 && x < .5) {
            if (Random.Range(-1, 1) < 0) {
                x = -3;
            } else {
                x = 3;
            }
        }

                if (y > -.5 && y < .5) {
            if (Random.Range(-1, 1) < 0) {
                y = -3;
            } else {
                y = 3;
            }
        }

        rb.velocity = new Vector2 (x, y);
    }
}
