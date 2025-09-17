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
    static int score = 0; // ��� ������Ʈ���� �����ϴ� ����
    bool wasBorken; // ���� ���� ������ ���� ����

    void Start()
    {
        animator = GetComponent<Animator>();
        col = GetComponent<PolygonCollider2D>();
        animator.SetBool("borken", false);
        animator.SetBool("idle", true);
        col.isTrigger = false;
        wasBorken = false; // �ʱ� ���� ����

        // scoreText�� �������� ã�� �Ҵ�
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

        // borken ���� Ȯ��
        if (animator.GetBool("borken"))
        {
            if (!wasBorken)
            {
                score += 10; // score ����
                UpdateScoreText();
                wasBorken = true; // ���� ���� ���� ����
            }
        }
        else
        {
            wasBorken = false; // borken ���°� �����Ǿ��� �� ���� ���� �ʱ�ȭ
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