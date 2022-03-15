using UnityEngine;
using System.Collections;

public class LeftSideJump : MonoBehaviour
{
    public bool leftJumpRdy;

    void Start()
    {
        leftJumpRdy = false;
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        leftJumpRdy = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        leftJumpRdy = false;
    }


}
