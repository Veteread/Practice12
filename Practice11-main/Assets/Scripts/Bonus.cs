using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Bonus : MonoBehaviour
{
    public MeshRenderer BonusObj;
    public ParticleSystem BurstBonus;

    private void Awake()
    {
        BonusObj = GetComponent<MeshRenderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BurstBonus.Play(true);
            BonusObj.enabled = false;                  
            Invoke("Del", 2f);
        }
    }

    private void Del()
    {
      ParticleSystem.Destroy(BurstBonus, 1f); 
    }
}
