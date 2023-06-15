using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 태어날 때 GameOverUI를 비활성화 하고싶다.
// 플레이어의 체력이 0이 될 때 GameOverUI를 활성화 하고싶다.
// 재시작 버튼을 누르면 재시작 하고싶다.
// 종료 버튼을 누르면 종료하고싶다.
public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public static GameManager instance;

    public Button buttonRestart;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        // 태어날 때 GameOverUI를 비활성화 하고싶다.
        gameOverUI.SetActive(false);

        buttonRestart.onClick.AddListener(Restart);
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
