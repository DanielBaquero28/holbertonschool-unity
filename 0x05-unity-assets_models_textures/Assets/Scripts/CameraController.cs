using UnityEngine;

public class CameraController : MonoBehaviour
{
    /// <summary> Mouse Sensitivity </summary>
    public float mouseSpeed = 100f;
    /// <summary> Player's Position </summary>
    public Transform playerBody;
    /// <summary> Horizontal rotation </summary>
    float xRotation = 0.0f;
    private float xAxisClamp;

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

        //playerBody.Rotate(Vector3.up * mouseX);

        xAxisClamp -= mouseY;

        if (xAxisClamp > 90.0f)
        {
            xAxisClamp = 90.0f;
            mouseY = 0.0f;
            ClampxAxisRotationToValue(270.0f);
        }
        else if (xAxisClamp < -90.0f)
        {
            xAxisClamp = -90.0f;
            mouseY = 0.0f;
            ClampxAxisRotationToValue(90.0f);
        }

        transform.Rotate(-transform.right * mouseY);
    }

    private void ClampxAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
