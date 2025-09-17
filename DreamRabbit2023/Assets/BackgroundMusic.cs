using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true; // 배경음악을 반복 재생합니다.
        audioSource.Play(); // 배경음악을 재생합니다.
    }
}
