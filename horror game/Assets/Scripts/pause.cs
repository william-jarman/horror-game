using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject pausemenu;
    public bool toggle;
    public SC_FPSController playerscript;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toggle = !toggle;
            if(toggle == false)
            {
                pausemenu.SetActive(false);
                playerscript.enabled = true;
                Time.timeScale = 1;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                AudioListener.pause = false;
            }
            if (toggle == true)
            {
                pausemenu.SetActive(true);
                playerscript.enabled = false;
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                AudioListener.pause = true;
            }
        }
    }
}