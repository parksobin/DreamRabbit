using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    public int power=250;
    public Rigidbody2D charrb;
    bool JumpState;

    Animator animator;
    int score;

    public GameObject EndCanvas;

    void Start()
    {
        animator = GetComponent<Animator>();
        JumpState = true;
        animator.SetBool("jump", false);
        animator.SetBool("dash", false);
        score = 0;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            switch (JumpState)
            {
                case true:
                    animator.SetBool("jump", true);
                    animator.SetBool("walk", false);
                    animator.SetBool("dash", false);
                    charrb.AddForce(Vector2.up * power);
                    print("jump");
                    JumpState = false;
                    break;
                case false:
                    break;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            animator.SetBool("jump", false);
            animator.SetBool("walk", true);
            animator.SetBool("dash", false);
            JumpState = true;
            Debug.Log("¡¢√À Ω√¿€");
        }
        if (collision.gameObject.tag == "Block")
        {
            score += 10;
        }
        if (collision.gameObject.tag == "DelZone")
        {
            Time.timeScale = 0;
            EndCanvas.SetActive(true);
        }
    }


    public void JumpBT()
    {
        switch(JumpState) 
        {
            case true:
                animator.SetBool("jump", true);
                animator.SetBool("walk", false);
                animator.SetBool("dash", false);
                charrb.AddForce(Vector2.up * power);
                print("jump");
                JumpState = false;
                break;
            case false: 
                break;
        }
    }


}
