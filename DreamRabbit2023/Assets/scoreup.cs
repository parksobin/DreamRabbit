using UnityEngine;

public class scoreup : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("score"))
        {
            other.gameObject.SetActive(false);
            score1.score2 += 10;

        }
    }
}
