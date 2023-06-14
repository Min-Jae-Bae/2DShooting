using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// �¾ �� GameOverUI�� ��Ȱ��ȭ �ϰ�ʹ�.
// �÷��̾��� ü���� 0�� �� �� GameOverUI�� Ȱ��ȭ �ϰ�ʹ�.
// ����� ��ư�� ������ ����� �ϰ�ʹ�.
// ���� ��ư�� ������ �����ϰ�ʹ�.
public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        // �¾ �� GameOverUI�� ��Ȱ��ȭ �ϰ�ʹ�.
        gameOverUI.SetActive(false);
    }

    void Update()
    {

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
