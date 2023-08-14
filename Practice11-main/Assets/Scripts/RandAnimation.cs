using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandAnimation : MonoBehaviour
{
    private Animator anim;
    private int rand;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    public void NextAnim()
    {
    	rand = Random.Range(0,3);
        anim.SetInteger("Rand", rand);
    }    
}
