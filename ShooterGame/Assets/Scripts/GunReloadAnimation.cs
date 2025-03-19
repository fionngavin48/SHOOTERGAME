using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;

public class GunReloadAnimation : MonoBehaviour
{
    
    private Animator animator; 

    public int delay = 2000;
   

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isReloading", false);
    }
    

    async void Update()
    {

        if(Input.GetButtonDown("R"))
        {
        
        animator.SetBool("isReloading", true);
        await Task.Delay(delay);

        animator.SetBool("isReloading", false);
        await Task.Delay(delay);

        }

        

    }
}
