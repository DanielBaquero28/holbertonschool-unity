using UnityEngine;

/// <summary> Controls the Cutscene Camera </summary>
public class CutsceneController : MonoBehaviour
{
    /// <summary> Main Camera </summary>
    public GameObject mainCamera;
    /// <summary> Player Controller script </summary>
    public GameObject playerController;
    /// <summary> Timer </summary>
    public GameObject timer;
    /// <summary> Cut Camera Controller </summary>
    public GameObject cutController;

    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void makeTransition()
    {
        mainCamera.SetActive(true);
        playerController.gameObject.GetComponent<PlayerController>().enabled = true;
        timer.SetActive(true);
        cutController.SetActive(false);
    }
}
