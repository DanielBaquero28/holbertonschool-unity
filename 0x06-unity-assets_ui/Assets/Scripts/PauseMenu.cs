using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    /// <summary> Pause Canvas GameObject </summary>
    public GameObject PauseCanvas;

    private bool pausedMenu = false;

    public void Start()
    {
        Cursor.visible = false;
    }


    public void Update()
    {
        //Debug.Log("Update: " + Cursor.lockState);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("Entered Update");
            if (pausedMenu == true)
            {
                Resume();
                //Debug.Log("pausedMenu = true: " + Cursor.lockState);
            }
            else
            {
                Pause();
                //Debug.Log("else: " + Cursor.lockState);
            }
        }
    }  

    public void Pause()
    {
        pausedMenu = true;
        PauseCanvas.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        //Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausedMenu = false;
        PauseCanvas.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void MainMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        PlayerPrefs.SetString("lastLoadedScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(1);
    }
}
