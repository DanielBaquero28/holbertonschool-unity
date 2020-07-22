using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class VolumeController : MonoBehaviour
{
    public AudioSource music1;
    //public AudioSource music2;

    public Slider BGM;
    public Slider SFX;


    // Start is called before the first frame update
    void Start()
    {
        BGM.value = PlayerPrefs.GetFloat("BGM");
        SFX.value = PlayerPrefs.GetFloat("SFX");
    }

    // Update is called once per frame
    void Update()
    {
        music1.volume = BGM.value;
        //music2.volume = BGM.value;
    }

    public void VolumePrefs()
    {
        PlayerPrefs.SetFloat("BGM", music1.volume);
        //PlayerPrefs.SetFloat("BGM2", music2.volume);
        PlayerPrefs.SetFloat("SFX", SFX.value);
    }
}
