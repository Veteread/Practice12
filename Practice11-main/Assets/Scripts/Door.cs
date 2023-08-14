using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject DoorOpen;

    private void OnTriggerStay(Collider other)
    {       
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e"))
            {
                DoorOpen.SetActive(false);
            }
        }
    }
}
