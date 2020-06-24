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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("Entered Update");
            if (pausedMenu == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }  

    public void Pause()
    {
        pausedMenu = true;
        PauseCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausedMenu = false;
        PauseCanvas.SetActive(false);
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
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        SceneManager.LoadScene(1);
    }
}
