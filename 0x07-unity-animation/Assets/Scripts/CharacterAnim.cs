using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    Animator anim;
    /// <summary> Player's Transform Component </summary>
    public Transform playerPos;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }

        if (playerPos.position.y == 40.0f)
        {
            //Debug.Log("Checking if enters conditional to trigger");
            anim.SetTrigger("isFalling");
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("isFalling"))
        {
            Debug.Log("Activated Trigger isFalling");
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
        {
            Debug.Log("Activated Triger Jump");
        }
        
    }
}
