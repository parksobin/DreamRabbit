using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutZoneEnd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boundary"))
        {
            // �ٱ� ���� �浹�ϸ� ���� ���� ȭ���� ���� �Լ��� ȣ���ϰų� ���ϴ� ������ �����մϴ�.
            Debug.Log("�浹");
        }
    }

}
