using UnityEngine;

public class CameraController : MonoBehaviour
{
    /// <summary> Mouse Sensitivity </summary>
    public float mouseSpeed = 100f;
    /// <summary> Player's Position </summary>
    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSpeed;

        playerBody.Rotate(Vector3.up * mouseX);
    }

    void LateUpdate()
    {
        if (playerBody.position.y < -30.0f)
        {
            transform.position = new Vector3(0, 40, 0);
        }
    }
}
