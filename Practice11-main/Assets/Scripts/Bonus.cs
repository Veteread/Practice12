using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Bonus : MonoBehaviour
{
    public GameObject BonusDel;
    public MeshRenderer BonusObj;
    public ParticleSystem BurstBonus;
    private AudioSource bonusSound;

    private void Awake()
    {
        BonusObj = GetComponent<MeshRenderer>();
        bonusSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BurstBonus.Play(true);
            BonusObj.enabled = false;
            bonusSound.Play();                      
            Invoke("Del", 1f);
        }
    }

    private void Del()
    {
        DataContainer.SumBonus++;
        GameObject.Destroy(BonusDel, 1f);        
    }
}
