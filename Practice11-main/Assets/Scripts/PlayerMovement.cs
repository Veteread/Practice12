using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(0, 20)] private float speed = 2.0f;
    private Rigidbody playerRigidbody;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    public void MoveCharacter(Vector3 movement)
    {
        playerRigidbody.AddForce(movement * speed);
    }
}
