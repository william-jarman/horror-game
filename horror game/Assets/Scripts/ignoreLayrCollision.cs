using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreLayrCollision : MonoBehaviour
{
    void Start()
    {
        Physics.IgnoreLayerCollision(6, 7);
    }
}
