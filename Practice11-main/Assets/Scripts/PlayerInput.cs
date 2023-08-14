using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{
    private Vector3 movement;
    private PlayerMovement playerMovement;
    private SceneManagement sceneManagement;

    private void Awake()
    {
       playerMovement = GetComponent<PlayerMovement>(); 
       sceneManagement = GetComponent<SceneManagement>();
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");        
        movement = new Vector3(horizontal, 0, vertical).normalized;
    }

    private void FixedUpdate()
    {
        playerMovement.MoveCharacter(movement);       
    }
}
