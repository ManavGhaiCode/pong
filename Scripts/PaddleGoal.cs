using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaddleGoal : MonoBehaviour {
    public TextController winStr;
    public TextController txt;
    public Transform win;

    public int playerNum;

    int Score = 9;

    private void OnTriggerEnter2D(Collider2D hitInfo) {
        Ball ball = hitInfo.GetComponent<Ball>();

        if (ball != null) {
            ball.ResetBall();

            Score += 1;
            txt.SetText(Score.ToString());

            if (Score >= 10) {
                win.position = new Vector3 (0, 10, 0);

                winStr.SetText("Player " + playerNum.ToString());

                foreach (Rigidbody2D rb in GameObject.FindObjectsOfType<Rigidbody2D>()) {
                    rb.bodyType = RigidbodyType2D.Static;
                }

                StartCoroutine(ResetScene());
            }
        }
    }

    private IEnumerator ResetScene() {
        yield return new WaitForSeconds (2f);
        SceneManager.LoadScene("Game");
    }
}
