using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class insertFloppyDisk : MonoBehaviour
{
    public Animator diskAnim;
    public GameObject intText, disk;
    public bool interactable, toggle;
    public string levelName;
    public float levelTransitionTime;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if(toggle == false)
            {
                if(disk.active == false)
                {
                    intText.SetActive(true);
                    interactable = true;
                }
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                diskAnim.SetTrigger("insert");
                intText.SetActive(false);
                StartCoroutine(loadNextLevel());
                toggle = false;
                interactable = false;
            }
        }
    }
    IEnumerator loadNextLevel()
    {
        yield return new WaitForSeconds(levelTransitionTime);
        SceneManager.LoadScene(levelName);
    }
}