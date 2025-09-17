using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DashEffact : MonoBehaviour
{
    public GameObject Dashef;
    bool sign;
    float timers;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        Dashef.SetActive(false);
        sign = false;
        timers = 0;
        animator.SetBool("walk", true);
        animator.SetBool("jump", false);
        animator.SetBool("dash", false);
    }

    void Update()
    {

        if (sign) 
        {
            Dashef.SetActive(true);
            animator.SetBool("walk", false);
            animator.SetBool("dash", true);
            animator.SetBool("jump", false);
            timers += Time.deltaTime;
            if (timers > 1.0f)
            {
                Dashef.SetActive(false) ;
                animator.SetBool("walk", true);
                animator.SetBool("dash", false);
                animator.SetBool("jump", false);
                timers = 0;
                sign = false;
            }
        }
    }

    public void btOnclick()
    {
        sign = true;
    }


}
