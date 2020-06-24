using UnityEngine;

public class CameraController : MonoBehaviour
{
    /// <summary> Mouse Sensitivity </summary>
    public float mouseSpeed = 100f;
    /// <summary> Player's Position </summary>
    public Transform playerBody;
    public Transform lookAt;

    /// <summary> Checks if camera inverted </summary>
    public bool isInverted;

    /// <summary> Mouse Y </summary>
    float mouseY;
    /// <summary> Mouse X </summary>
    float mouseX;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        if (PlayerPrefs.GetString("isInverted") == "False")
        {
            isInverted = true;
        }
        else
        {
            isInverted = false;
        }
        playerBody = transform;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * Time.deltaTime * mouseSpeed;
        mouseY += Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSpeed * (isInverted ? -1 : 1);
        mouseY = Mathf.Clamp(mouseY, -30f, 40f);

        //playerBody.Rotate(Vector3.up * mouseX);
    }

    void LateUpdate()
    {
        Vector3 vector = new Vector3(0, 2.0f, -5.0f);
        Quaternion rotation = Quaternion.Euler(mouseY, mouseX, 0f);
        playerBody.position = lookAt.position + rotation * vector;
        playerBody.LookAt(lookAt.position);
        if (playerBody.position.y < -30.0f)
        {
            transform.position = new Vector3(0, 40, 0);
        }
    }
}
