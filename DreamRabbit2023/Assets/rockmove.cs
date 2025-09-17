using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockmove : MonoBehaviour
{
    float Rand;
    public int speed;
    void Start()
    {
        Rand = Random.Range(4.0f, 6.5f);
    }

    void Update()
    {
        transform.Translate(Vector2.left * Rand * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DelZone"))
        {
            Destroy(gameObject);
        }
    }
}
