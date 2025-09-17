using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class play : MonoBehaviour
{
    public Button button;
    public AudioSource soundEffect;
    public string nextSceneName = "Restart"; // ���� �� �̸� ����

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
        yield return new WaitForSeconds(1f); // 1�� ���� ��ٸ��ϴ�.

        // ���� ������ ��ȯ
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}



