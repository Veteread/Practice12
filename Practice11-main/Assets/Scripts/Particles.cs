using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Particles : MonoBehaviour
{
    public Text TextFinish;
    public Camera Camera1;
    public Camera Camera2;
    public Rigidbody RbBall;
    public List<ParticleSystem> particles = new List<ParticleSystem>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RbBall.isKinematic = true;
            Camera2.enabled = true;
            Camera1.enabled = false;
            Camera2 = Camera.main;
            TextFinish.text = "Поздравляем! С ПОБЕДОЙ!";
            foreach (ParticleSystem p in particles)
            {
                p.Play(true);
            }
        }
    }
}
