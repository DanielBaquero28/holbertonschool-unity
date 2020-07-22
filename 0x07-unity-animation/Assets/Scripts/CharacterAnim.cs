using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    Animator anim;
    /// <summary> Player's Transform Component </summary>
    public Transform playerPos;

    int flagFalling = 0;

    AnimatorClipInfo[] clipInfo;

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
            flagFalling = 1;
        }

        if (flagFalling == 1 && (int)playerPos.position.y == 1)
        {
            //Debug.Log("Entered condition flatImpact");
            anim.SetTrigger("flatImpact");
            anim.ResetTrigger("isFalling");
            flagFalling = 0;
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("isFalling"))
        {
            //Debug.Log("Activated Trigger isFalling");
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
        {
            //Debug.Log("Activated Trigger Jump");
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("flatImpact"))
        {
            //Debug.Log("Activated Trigger flatImpact");
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("isFalling"))
        {
            //Debug.Log("Activated Trigger isFalling");
        }

        //clipInfo = anim.GetCurrentAnimatorClipInfo(0);
        //Debug.Log(clipInfo[0].clip.name);
        //Debug.Log((int)playerPos.position.y);
        
    }
}
