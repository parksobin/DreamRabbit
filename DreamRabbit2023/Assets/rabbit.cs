using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class rabbit : MonoBehaviour
{
    public Rigidbody2D rbody;
    public int jumppower;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rbody.velocity = Vector2.up * jumppower;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (score1.score2 > score1.bestscore)
        {
            score1.bestscore = score1.score2;
        }
        // �浹�� ������Ʈ�� �±װ� "Boundary"���� Ȯ���մϴ�.
        if (collision.gameObject.CompareTag("Boundary"))
        {
            // ���� ���� ���� �ε��մϴ�.
            SceneManager.LoadScene("GameOver");
        }
    }

}
