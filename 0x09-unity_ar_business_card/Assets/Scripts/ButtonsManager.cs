using UnityEngine;

/// <summary> Handles the actions that take place when clicked on </summary>
public class ButtonsManager : MonoBehaviour
{
    /// <summary> Takes user to my LinkedIn Account </summary>
    public void ClickLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/daniel-alejandro-baquero-arias-106a45195/");
    }

    /// <summary> Takes user to send a mail to my email address </summary>
    public void ClickEmail()
    {
        Application.OpenURL("mailto:danielalejandrobaquero@hotmail.com");
    }

    /// <summary> Takes the user to my GitHub Account </summary>
    public void ClickGithub()
    {
        Application.OpenURL("https://github.com/DanielBaquero28");
    }

    /// <summary> Takes the user to my Twitter Account </summary>
    public void ClickTwitter()
    {
        Application.OpenURL("https://twitter.com/DanielB30589105");
    }

}
