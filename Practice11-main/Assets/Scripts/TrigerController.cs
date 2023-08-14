using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigerController : MonoBehaviour
{
    private SceneManagement sceneManagement;   
    private void Awake()
    {
        sceneManagement = GetComponent<SceneManagement>();      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathTrigger"))
        {
            sceneManagement.ThisScene();
        }       
    }

       private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Finish"))
        {           
            sceneManagement.NextScene();         
        }       
    }
}
