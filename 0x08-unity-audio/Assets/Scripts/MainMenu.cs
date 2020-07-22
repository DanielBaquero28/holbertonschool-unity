using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class MainMenu : MonoBehaviour
{
    public AudioSource music;

    void Start()
    {
        music.volume = PlayerPrefs.GetFloat("BGM");
    }
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Options()
    {
        PlayerPrefs.SetString("lastLoadedScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}
