using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class play : MonoBehaviour
{
    public Button button;
    public AudioSource soundEffect;
    public string nextSceneName = "Restart"; // 다음 씬 이름 설정

    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        if (soundEffect != null)
        {
            soundEffect.Play();
            StartCoroutine(WaitAndLoadScene());
        }
    }

    private IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(1f); // 1초 동안 기다립니다.

        // 다음 씬으로 전환
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}



