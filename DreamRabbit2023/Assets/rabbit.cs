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
        // 충돌한 오브젝트의 태그가 "Boundary"인지 확인합니다.
        if (collision.gameObject.CompareTag("Boundary"))
        {
            // 게임 오버 씬을 로드합니다.
            SceneManager.LoadScene("GameOver");
        }
    }

}
