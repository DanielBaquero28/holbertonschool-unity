using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

/// <summary> Winning Class in charge of stopping timer </summary>
public class WinTrigger : MonoBehaviour
{
    /// <summary> Player GameObject </summary>
    public GameObject player;
    /// <summary> UI Timer Text </summary>
    public Text timeText;
    /// <summary> WinCanvas GameObject </summary>
    public GameObject winCanvas;
    /// <summary> Winner Time Text </summary>
    public Text winText;
    /// <summary> Background audio Source </summary>
    public AudioSource backgroundAudio;
    /// <summary> Win Sting Audio </summary>
    public AudioSource winSting;
    bool confined = false;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (confined)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    void OnTriggerEnter()
    {
        confined = true;
        player.GetComponent<Timer>().enabled = false;
        player.GetComponent<PlayerController>().enabled = false;
        winCanvas.SetActive(true);
        timeText.gameObject.SetActive(false);
        //Debug.Log("Time Text:" + timeText.text);
        winText.text = timeText.text;
        backgroundAudio.Stop();
        winSting.Play();
        //Debug.Log("WinText: " + winText.text);
    }
}
