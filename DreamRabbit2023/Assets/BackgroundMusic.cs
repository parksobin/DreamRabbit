using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true; // ��������� �ݺ� ����մϴ�.
        audioSource.Play(); // ��������� ����մϴ�.
    }
}
