using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//�¾ �� ������ 0������ �ϰ� �ʹ�. UI�ε� ǥ���ϰ� �ʹ�.
//���� �Ѿ˰� �ε����ٸ� ������ 1�� ������Ű�� �ʹ�.
//�¾ �� �ְ������� �о����ʹ�. UI�ε� ǥ���ϰ� �ʹ�.
//������ ���ŵɶ� ���� �ְ��������� ũ�ٸ� �ְ� ������ ���ŵ� ������ �ٲٰ� �����ϰ� �ʹ�.
public class ScoreManager : MonoBehaviour
{
    // ��� - �б� ����
    readonly string highScoreKey = "HIGH_SCORE";
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textHighScore;
    public static ScoreManager instance;
    int highScore;
    int score;

    // �̱��� ���� ����
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        SCORE = 0;

        //�¾ �� �ְ������� �о����ʹ�. UI�ε� ǥ���ϰ� �ʹ�.
        HIGH_SCORE = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    // ȣ���ϴ� ���� ������Ƽ
    public int SCORE
    {
        set
        {
            score = value;
            textScore.text = "Score : " + score;
            // ���� Score�� HighScore���� ũ�ٸ�
            if (score > HIGH_SCORE)
            {
                //highScore�� scroe�� �����ϰ� �ʹ�.
                HIGH_SCORE = score;
                // �����ϰ� �ʹ�. ������ ���̽��� �� �� �ִ�.
                PlayerPrefs.SetInt(highScoreKey, HIGH_SCORE);
            }
        }

        get
        {
            return score;
        }
    }

    public int HIGH_SCORE
    {
        set
        {
            highScore = value;
            textHighScore.text = "HighScore: " + highScore;
        }

        get
        {
            return highScore;
        }
    }
}
