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
    public TextMeshProUGUI textScore;
    public static ScoreManager instance;
    int score;

    // �̱��� ���� ����
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        SCORE = 0;
    }

    // ȣ���ϴ� ���� ������Ƽ
    public int SCORE
    {
        set
        {
            score = value;
            textScore.text = "Score : " + score;
            // ���� Score�� HighScore���� ũ�ٸ� �����ϰ� �ʹ�.
        }

        get 
        {
            return score; 
        }
    }
}
