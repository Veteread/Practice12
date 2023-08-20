using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Portal : MonoBehaviour
{
    public Transform Ball;
    public Transform Port;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e"))
            {
                Ball.transform.position = Port.transform.position;
            }
        }
    }
}
