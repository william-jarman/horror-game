using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fnafCam : MonoBehaviour
{
    //The variables
    public Transform playerCam; 
    public int rotateSpeed, clampValue;
    public bool ADKeys, movingLeft, movingRight;

    void Start()
    {
        Application.targetFrameRate = 30;
    }

    void Update()
    {
        //If ADKeys is == true, you can rotate the camera left and right with the A and D keys. Leave false if you want to use regular FNAF camera style.
        if(ADKeys == true)
        {
            //When you hold A, the camera will rotate left.
            if (Input.GetKey(KeyCode.A))
            {
                if (playerCam.localRotation == Quaternion.Euler(0, -clampValue, 0))
                {

                }
                else
                {
                    playerCam.Rotate(0, -rotateSpeed, 0);
                }
            }
            //When you hold D, the camera will rotate right.
            if (Input.GetKey(KeyCode.D))
            {
                if (playerCam.localRotation == Quaternion.Euler(0, clampValue, 0))
                {

                }
                else
                {
                    playerCam.Rotate(0, rotateSpeed, 0);
                }
            }
        }
        //If ADKeys is == false, the normal FNAF camera rotation will be in play.
        if(ADKeys == false)
        {
            //If either movingLeft or movingRight is == true, the camera wil lrotate left or right.
            if(movingLeft == true)
            {
                if (playerCam.localRotation == Quaternion.Euler(0, -clampValue, 0))
                {

                }
                else
                {
                    playerCam.Rotate(0, -rotateSpeed, 0);
                }
            }
            if(movingRight == true)
            {
                if (playerCam.localRotation == Quaternion.Euler(0, clampValue, 0))
                {

                }
                else
                {
                    playerCam.Rotate(0, rotateSpeed, 0);
                }
            }
        }
    }
    //When the cursor is hovering over the button with the Trigger Event applied, depending on whether it's the left or right button, the camera will start rotating left or right.
    //Upon the cursor exiting the button, the rotating will stop.
    public void rotateLeft()
    {
        movingLeft = true;
    }
    public void rotateRight()
    {
        movingRight = true;
    }
    public void stopRotateLeft()
    {
        movingLeft = false;
    }
    public void stopRotateRight()
    {
        movingRight = false;
    }
}
