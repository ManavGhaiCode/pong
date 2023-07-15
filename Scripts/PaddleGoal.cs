using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaddleGoal : MonoBehaviour {
    public TextController txt;

    int Score = 0;

    private void OnTriggerEnter2D(Collider2D hitInfo) {
        Ball ball = hitInfo.GetComponent<Ball>();

        if (ball != null) {
            ball.ResetBall();

            Score += 1;
            txt.SetText(Score.ToString());

            if (Score > 10) {
                SceneManager.LoadScene("Game");
            }
        }
    }
}
