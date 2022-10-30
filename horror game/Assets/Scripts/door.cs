using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
	//The door's Animator component
    public Animator doorAnimator;
	
    //The audio sources for the door
    public AudioSource lockedSound, openSound, closeSound;
	
    //Boolenas to determine whether door is interactable, locked, and opened/closed
    public bool interactable, locked, toggle;

    //An object that shows up to let you know you can interact with the door when looking at it.
    public GameObject intText;

	//If the player camera's trigger is colliding with the door and it's tagged as MainCamera, interactable will equal to true
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interactable = true;
            intText.SetActive(true);
        }
    }
    //If the player camera's trigger is exits out of collision with the door and it's tagged as MainCamera, interactable will equal to false
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interactable = false;
            intText.SetActive(false);
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //If interactable equals true, the player presses E, and the door is locked, the door locked animation will play and so will the locked sound
                if(locked == true)
                {
                    doorAnimator.ResetTrigger("open");
                    doorAnimator.ResetTrigger("close");
                    doorAnimator.SetTrigger("locked");
                    //lockedSound.Play();
                }
                //If interactable equals true, the player presses E, and the door is not locked, toggle will equal to the opposite of what it currently is
                if(locked == false)
                {
                    toggle = !toggle;
                    //If toggle equals false, the door will close and the close sound will play
                    if(toggle == false)
                    {
                        doorAnimator.ResetTrigger("open");
                        doorAnimator.ResetTrigger("locked");
                        doorAnimator.SetTrigger("close");
                        //closeSound.Play();
                    }
                    //If toggle equals true, the door will open and the open sound will play
                    if (toggle == true)
                    {
                        doorAnimator.ResetTrigger("close");
                        doorAnimator.ResetTrigger("locked");
                        doorAnimator.SetTrigger("open");
                        //openSound.Play();
                    }
                }
            }
        }
    }
}