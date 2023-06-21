using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// ���� �ı��� �� ����ġ�� 1 ȹ���ϰ�ʹ�.
// ����ġ�� 5���Ǹ� ������ �ϰ�ʹ�.
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
            //���� ������ 2���
            if (level == 2)
            {
                StageLevel.instance.LEVEL = 2;
            }
            // �������� ������ 1 ������Ű��ʹ�.
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
                //���� exp�� needExp�̻��̶��
                if (exp >= needExp)
                {
                    // ������ �ϰ�ʹ�.
                    LEVEL++;
                    exp -= needExp;
                }
            }
            if (count > 0)
            {
                // VFX����ó��..
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
