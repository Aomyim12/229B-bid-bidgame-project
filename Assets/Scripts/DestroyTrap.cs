using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrap : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Trap"))
        {
            Destroy(other);
        }
    }
}
