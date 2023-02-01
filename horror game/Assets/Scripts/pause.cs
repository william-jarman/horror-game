using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject pausemenu, settingsmenu, visualsmenu, audiomenu;
    public bool toggle;
    public SC_FPSController playerscript;
    public string sceneName;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toggle = !toggle;
            if(toggle == false)
            {
                pausemenu.SetActive(false);
                visualsmenu.SetActive(false);
                audiomenu.SetActive(false);
                settingsmenu.SetActive(false);
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
    public void openSettings()
    {
        pausemenu.SetActive(false);
        visualsmenu.SetActive(false);
        audiomenu.SetActive(false);
        settingsmenu.SetActive(true);
    }
    public void backToPauseMenu()
    {
        settingsmenu.SetActive(false);
        pausemenu.SetActive(true);
    }
    public void toVisuals()
    {
        settingsmenu.SetActive(false);
        visualsmenu.SetActive(true);
    }
    public void toAudio()
    {
        settingsmenu.SetActive(false);
        audiomenu.SetActive(true);
    }
    public void resumeGame()
    {
        toggle = false;
        pausemenu.SetActive(false);
        playerscript.enabled = true;
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        AudioListener.pause = false;
    }
    public void quitToMainMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        SceneManager.LoadScene(sceneName);
    }
    public void quitGame()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        Application.Quit();
    }
}