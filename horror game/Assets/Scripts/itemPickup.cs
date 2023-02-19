using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemPickup : MonoBehaviour
{
    //The GameObject variables
    public GameObject objectGround, objectHand, pickupText, intText;

    //String variables
    public string pickupString;

    //The Bools
    public bool isItemInHand, isTherePickupText, interactable, toggle, pickedup;

    //When player is looking at the item, interactable will equal to true.
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if(toggle == true)
            {
                intText.SetActive(true);
                interactable = true;
            }
        }
    }
    //When player is looking away from the item, interactable will equal to false.
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    //If interactable is true, the player can press E to pickup the item.
    void Update()
    {
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //If isItemInHand equals true, the item that was picked up will be in the player's hand.
                if (isItemInHand == true)
                {
                    objectHand.SetActive(true);
                }
                //If isTherePickupText equals true, the pickup text will appear.
                if (isTherePickupText == true)
                {
                    pickupText.gameObject.GetComponent<Text>().text = pickupString;
                    pickupText.SetActive(true);
                }
                pickedup = true;
                intText.SetActive(false);
                objectGround.SetActive(false);
                interactable = false;
            }
        }
    }
}
