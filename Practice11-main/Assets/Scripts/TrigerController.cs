using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigerController : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Burst;
    public Transform ballStart;
    private Rigidbody rb;
    private SceneManagement sceneManagement;
    private void Awake()
    {
        sceneManagement = GetComponent<SceneManagement>();
        rb = GetComponent<Rigidbody>();
    }

    private void Death()
    {
        Ball.transform.position = ballStart.transform.position;
        rb.isKinematic = false;
        Burst.SetActive(false);
        Ball.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathTrigger"))
        {
            rb.isKinematic = true;
            Ball.SetActive(false);
            Burst.transform.position = Ball.transform.position;
            Burst.SetActive(true);
            Invoke("Death", 3f);
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
