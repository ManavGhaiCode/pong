using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 2f;

    private Rigidbody2D rb;
    private float moveInput;

    [SerializeField] private string upButton;
    [SerializeField] private string downButton;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        moveInput = GetInput();
    }
    
    private void FixedUpdate() {
        float force = moveInput * Time.fixedDeltaTime * speed;

        rb.MovePosition(rb.position + new Vector2 (0, force));
    }

    private int GetInput() {
        if (Input.GetKey(upButton)) {
            return 1;
        } else if (Input.GetKey(downButton)) {
            return -1;
        } 

        return 0;
    }
}
