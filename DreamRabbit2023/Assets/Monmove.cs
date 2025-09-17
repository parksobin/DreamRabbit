using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Monmove : MonoBehaviour
{
    Animator animator;
    public int speed;
    PolygonCollider2D col;
    public TextMeshProUGUI scoreText;
    static int score = 0; // 모든 오브젝트에서 공유하는 점수
    bool wasBorken; // 상태 변경 감지를 위한 변수

    void Start()
    {
        animator = GetComponent<Animator>();
        col = GetComponent<PolygonCollider2D>();
        animator.SetBool("borken", false);
        animator.SetBool("idle", true);
        col.isTrigger = false;
        wasBorken = false; // 초기 상태 설정

        // scoreText를 동적으로 찾고 할당
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<TextMeshProUGUI>();
            if (scoreText == null)
            {
                Debug.LogError("scoreText is not assigned in the inspector and could not be found in the scene.");
            }
        }

        UpdateScoreText();
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // borken 상태 확인
        if (animator.GetBool("borken"))
        {
            if (!wasBorken)
            {
                score += 10; // score 증가
                UpdateScoreText();
                wasBorken = true; // 상태 변경 감지 설정
            }
        }
        else
        {
            wasBorken = false; // borken 상태가 해제되었을 때 감지 상태 초기화
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("dashzone"))
        {
            col.isTrigger = true;
            animator.SetBool("borken", true);
            animator.SetBool("idle", false);
        }

        if (collision.CompareTag("DelZone"))
        {
            Destroy(gameObject);
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score : " + score.ToString();
        }
    }
}