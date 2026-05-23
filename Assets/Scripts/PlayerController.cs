using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // This allows you to tweak the speed directly in the Unity Inspector
    public float speed = 10f;

    private Rigidbody rb;
    private float movementX;
    private float movementZ;

    void Start()
    {
        // Grab the Rigidbody component attached to the Player at the start of the game
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Capture input from WASD or Arrow keys every frame
        // This handles X (Left/Right) and Z (Forward/Backward in 3D space)
        movementX = Input.GetAxisRaw("Horizontal");
        movementZ = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Combine inputs into a movement vector on the X and Z axes
        Vector3 movement = new Vector3(movementX, 0.0f, movementZ).normalized;

        // Calculate the new position based on speed and physics time
        Vector3 newPosition = rb.position + movement * speed * Time.fixedDeltaTime;

        // Move the Rigidbody seamlessly through physics space
        rb.MovePosition(newPosition);
    }
}