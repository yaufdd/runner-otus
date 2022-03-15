using UnityEngine;
using System.Collections;

public class RightSideJump : MonoBehaviour
{
    public bool rightJumpRdy;

    void Start()
    {
        rightJumpRdy = false;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        rightJumpRdy = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        rightJumpRdy = false;
    }

}
