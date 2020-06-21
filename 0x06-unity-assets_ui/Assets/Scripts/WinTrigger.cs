using UnityEngine;
using UnityEngine.UI;

/// <summary> Winning Class in charge of stopping timer </summary>
public class WinTrigger : MonoBehaviour
{
    /// <summary> Player GameObject </summary>
    public GameObject player;
    /// <summary> UI Timer Text </summary>
    public Text timeText;

    void OnTriggerEnter()
    {
        player.GetComponent<Timer>().enabled = false;
        timeText.fontSize = 78;
        timeText.color = Color.green;
    }
}
