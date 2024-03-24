using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapAD : MonoBehaviour
{
    public GameObject TrapDoor;
    void OnTriggerEnter ()
    {
        TrapDoor.GetComponent<Animation>().Play("TrapA");
    } 
}
