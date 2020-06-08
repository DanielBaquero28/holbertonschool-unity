using UnityEngine;

/// <summary> Class in charge of triggering Timer script </summary>
public class TimerTrigger : MonoBehaviour
{
    /// <summary> GameObject where Timer script is attached </summary>
    public GameObject player;
    void OnTriggerExit(Collider other)
    {
        player.GetComponent<Timer>().enabled = true;
    }
}
