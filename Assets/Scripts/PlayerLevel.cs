using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// 적을 파괴될 때 경험치를 1 획득하고싶다.
// 경험치가 5가되면 레벨업 하고싶다.
public class PlayerLevel : MonoBehaviour
{

    public static PlayerLevel instance;
    long exp;
    public long needExp = 5;
    public RectTransform imageExp;
    public TextMeshProUGUI textExp;

    int level;
    public TextMeshProUGUI textLevel;

    public ParticleSystem levelUpParticleSystem;

    public int LEVEL
    {
        set
        {
            level = value;
            textLevel.text = "LV " + level;
            //만약 레벨이 2라면
            if (level == 2)
            {
                StageLevel.instance.LEVEL = 2;
            }
            // 스테이지 레벨을 1 증가시키고싶다.
        }

        get
        {
            return level;
        }
    }
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        EXP = 0;
        LEVEL = 1;
    }
    public long EXP
    {
        set
        {
            exp = value;

            long count = exp / needExp;
            for (int i = 0; i < count; i++)
            {
                //만약 exp가 needExp이상이라면
                if (exp >= needExp)
                {
                    // 레벨업 하고싶다.
                    LEVEL++;
                    exp -= needExp;
                }
            }
            if (count > 0)
            {
                // VFX연출처리..
                levelUpParticleSystem.Stop();
                levelUpParticleSystem.Play();
            }

            Vector3 ls = imageExp.localScale;
            float percent = (float)exp / (needExp);
            ls.x = percent;
            imageExp.localScale = ls;
            textExp.text = (percent * 100) + "%";
        }

        get
        {
            return exp;
        }


    }
}
