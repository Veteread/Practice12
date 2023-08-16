using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Bonus : MonoBehaviour
{
    public GameObject BonusObj;
    public ParticleSystem BurstBonus;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BonusObj.SetActive(false);            
            BurstBonus.Play(true);            
        }
    }
}
