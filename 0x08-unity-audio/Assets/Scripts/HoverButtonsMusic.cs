using UnityEngine;
using UnityEngine.Audio;

public class HoverButtonsMusic : MonoBehaviour
{
    AudioSource audioS;
    
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }
    void PlaySound()
    {
        audioS.Play();
    }
}
