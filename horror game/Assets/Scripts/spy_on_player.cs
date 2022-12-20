using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spy_on_player : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent monsterAI;
    public GameObject playerObj, monsterObj;
    Vector3 destination;
    public bool following;

    void Start()
    {
        if(playerObj.active == true)
        {
            following = true;
        }
    }
    void Update()
    {
        if(following == true)
        {
            destination = player.position;
            monsterAI.destination = destination;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("playerSight"))
        {
            following = false;
            monsterObj.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("playerSight"))
        {
            following = true;
            monsterObj.SetActive(true);
        }
    }
}