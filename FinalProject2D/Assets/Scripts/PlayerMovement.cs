using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //total points: 3
    public float originalMoveSpeed;
    public float originalJumpPower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isRightPressed = false;
        isRightPressed = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
        if (isRightPressed)
        {

        }
        bool isLeftPressed = false;
        isLeftPressed = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        if (isLeftPressed)
        {

        }
        bool isSpacePressed = false;
        isSpacePressed = Input.GetKey(KeyCode.Space);
        if (isSpacePressed) 
        { 
        
        }
    }
}
