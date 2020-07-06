using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void MainMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }

    public void Next()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (sceneIndex >= 4)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene( sceneIndex + 1);
        }
    }
}
