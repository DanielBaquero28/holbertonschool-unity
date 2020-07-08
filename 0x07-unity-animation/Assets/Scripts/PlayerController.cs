using UnityEngine;

/// <summary> Class that handles Player's movement </summary>
public class PlayerController : MonoBehaviour
{
    /// <summary> Player's Character Controller </summary>
    public CharacterController controller;
    /// <summary> Player's movement speed </summary>
    public float speed = 12f;
    /// <summary> Gravity </summary>
    float gravity = -9.81f * 2.2f;
    /// <summary> Jump force </summary>
    float jumpForce = 3f;
    /// <summary> Player's velocity </summary>
    Vector3 velocity;
    /// <summary> Capsules's Collider </summary>
    public CapsuleCollider col;
    /// <summary> Layer Mask </summary>
    public LayerMask groundLayers;
    /// <summary> Player's Transform Component </summary>
    public Transform playerPos;
    public static int isFalling = 0;

    void FixedUpdate()
    {
        if (playerPos.position.y > -1f)
        {
            isFalling = 0;
        }
        isFalling = 0;

        if (IsGrounded() && velocity.y < 0)
        {
            velocity.y = -2.2f;
        }


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;

        controller.Move(move * speed * Time.deltaTime);

        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (playerPos.position.y < -30f)
		{
            isFalling = 1;
			playerPos.position = new Vector3(0, 40, 0);
		}
    }

    private bool IsGrounded()
    {
        return (Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x,
        col.bounds.min.y, col.bounds.center.z),col.radius * 0.9f, groundLayers));
    }
}
