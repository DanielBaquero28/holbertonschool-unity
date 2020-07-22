using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    /// <summary> Toggle of inverted mouse </summary>
    public Toggle isInverted;
    /// <summary> BGM AudioMixer </summary>
    //public AudioMixer MasterMixer;

    public void Start()
    {
        if (PlayerPrefs.GetString("isInverted") != string.Empty)
        {
            isInverted.isOn = bool.Parse(PlayerPrefs.GetString("isInverted"));
        }
    }
    public void Back()
    {
        //Debug.Log(PlayerPrefs.GetString("lastLoadedScene"));
        SceneManager.LoadScene(PlayerPrefs.GetString("lastLoadedScene"));
    }

    public void Apply()
    {
        PlayerPrefs.SetString("isInverted", isInverted.isOn.ToString());
    }

    
}
