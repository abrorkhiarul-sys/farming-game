using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;          // Kecepatan gerak
    private Rigidbody2D rb;               // Komponen Rigidbody2D
    private Vector2 moveInput;            // Input WASD

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // Ambil Rigidbody2D
    }

    void Update()
    {
        // Ambil input WASD
        float moveX = Input.GetAxisRaw("Horizontal"); // A (-1), D (1)
        float moveY = Input.GetAxisRaw("Vertical");   // S (-1), W (1)

        moveInput = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        // Gerakkan player
        rb.linearVelocity = moveInput * moveSpeed;
    }
}
