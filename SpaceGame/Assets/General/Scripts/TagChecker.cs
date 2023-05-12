using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagChecker : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Door")
        {
            if (other.GetComponent<DoorTrigger>().Moving == false)
            {
                other.GetComponent<DoorTrigger>().Moving = true;
            }
        }
    }
}
