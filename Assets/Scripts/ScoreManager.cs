using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//태어날 때 점수를 0점으로 하고 싶다. UI로도 표현하고 싶다.
//적이 총알과 부딪혔다면 점수를 1점 증가시키고 싶다.
//태어날 때 최고점수를 읽어오고싶다. UI로도 표현하고 싶다.
//점수가 갱신될때 만약 최고점수보다 크다면 최고 점수를 갱신된 점수로 바꾸고 저장하고 싶다.
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public static ScoreManager instance;
    int score;

    // 싱글톤 패턴 생성
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        SCORE = 0;
    }

    // 호출하는 입장 프로퍼티
    public int SCORE
    {
        set
        {
            score = value;
            textScore.text = "Score : " + score;
            // 만약 Score가 HighScore보다 크다면 저장하고 싶다.
        }

        get 
        {
            return score; 
        }
    }
}
