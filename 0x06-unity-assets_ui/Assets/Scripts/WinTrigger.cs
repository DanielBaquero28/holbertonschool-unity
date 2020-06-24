using UnityEngine;
using UnityEngine.UI;

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

    bool confined = false;

    void Update()
    {
        if (confined)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
            Cursor.lockState = CursorLockMode.Locked;
    }

    void OnTriggerEnter()
    {
        confined = true;
        Debug.Log("Cursor: " + Cursor.lockState);
        player.GetComponent<Timer>().enabled = false;
        winCanvas.SetActive(true);
        timeText.gameObject.SetActive(false);
        //Debug.Log("Time Text:" + timeText.text);
        winText.text = timeText.text;
        //Debug.Log("WinText: " + winText.text);
    }
}
