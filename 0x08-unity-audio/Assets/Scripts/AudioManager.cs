using UnityEngine;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{
    /// <summary> Background Audio </summary>
    public AudioSource backgroundMusic;
    /// <summary> Running Grass Audio </summary>
    public AudioSource runningGrass;
    /// <summary> Landing Grass Audio </summary>
    public AudioSource landingGrass;
    /// <summary> Player's Character Controller </summary>
    public CharacterController cc;
    /// <summary> Capsules's Collider </summary>
    public CapsuleCollider col;
    /// <summary> Layer Mask </summary>
    public LayerMask groundLayers;
    /// <summary> Player's Transform Component </summary>
    public Transform playerPos;
    /// <summary> Paused Audio Mixer Snapshot </summary>
    public AudioMixerSnapshot paused;
    /// <summary> Unpaused Audio Mixer Snapshot </summary>
    public AudioMixerSnapshot unpaused;
    int flagFalling = 0;

    void Start()
    {
        backgroundMusic.volume = PlayerPrefs.GetFloat("BGM");
        runningGrass.volume = PlayerPrefs.GetFloat("SFX");
        landingGrass.volume = PlayerPrefs.GetFloat("SFX");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Pause();

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

    public void Pause()
    {
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        Lowpass();
    }

    void Lowpass()
    {
        if (Time.timeScale == 0)
            unpaused.TransitionTo(0.01f);
        else
            paused.TransitionTo(0.01f);
    }
    private bool IsGrounded()
    {
        return (Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x,
        col.bounds.min.y, col.bounds.center.z),col.radius * 0.9f, groundLayers));
    }
}
