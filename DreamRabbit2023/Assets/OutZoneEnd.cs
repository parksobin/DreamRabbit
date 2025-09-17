using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutZoneEnd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boundary"))
        {
            // 바깥 경계와 충돌하면 게임 종료 화면을 띄우는 함수를 호출하거나 원하는 동작을 수행합니다.
            Debug.Log("충돌");
        }
    }

}
