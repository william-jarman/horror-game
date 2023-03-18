using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stamina : MonoBehaviour
{
    public Slider staminaBar;
    public float drainRate, rechargeRate, sprintSpeed;
    public SC_FPSController player;
    
    void Update()
    {
        if(staminaBar.value == 0f)
        {
            player.runningSpeed = player.walkingSpeed;
        }
        else if(staminaBar.value > 0f)
        {
            player.runningSpeed = sprintSpeed;
        }
        if(staminaBar.value == 1)
        {
            staminaBar.gameObject.SetActive(false);
        }
        if(staminaBar.value < 1)
        {
            staminaBar.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    if (staminaBar.value == 0f)
                    {
                        player.runningSpeed = player.walkingSpeed;
                    }
                    staminaBar.value = staminaBar.value - drainRate * Time.deltaTime;
                }
            }
        }
        else
        {
            staminaBar.value = staminaBar.value + rechargeRate * Time.deltaTime;
        }
    }
}
