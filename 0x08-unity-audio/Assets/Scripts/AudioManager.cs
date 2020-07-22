using UnityEngine;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{
    public AudioSource runningGrass;

    public AudioSource landingGrass;
    public CharacterController cc;

    /// <summary> Capsules's Collider </summary>
    public CapsuleCollider col;
    /// <summary> Layer Mask </summary>
    public LayerMask groundLayers;
    /// <summary> Player's Transform Component </summary>
    public Transform playerPos;

    int flagFalling = 0;

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D)) && IsGrounded())
        {
            //Debug.Log("Started");
            runningGrass.pitch = Random.Range(0.8f, 1.1f);
            runningGrass.enabled = true;
        }
        else
        {
            //Debug.Log("Pause: " + runningGrass.time);
            runningGrass.enabled = false;
        }

        if (playerPos.position.y == 40.0f)
        {
            landingGrass.enabled = false;
            flagFalling = 1;
        }
        if (flagFalling == 1 && (int)playerPos.position.y == 1)
        {
            //Debug.Log("Landed audio");
            landingGrass.enabled = true;
            flagFalling = 0;
        }
        
    }

    private bool IsGrounded()
    {
        return (Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x,
        col.bounds.min.y, col.bounds.center.z),col.radius * 0.9f, groundLayers));
    }
}
