using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// �¾ �� ü���� �ִ�ü������ �ϰ�ʹ�. UI�� ó���ϰ� �ʹ�.
// �Ѿ� Ȥ�� �÷��̾�� �ε��� �� ü���� 1 �����ϰ�ʹ�. ü���� 0�̵Ǹ� �ı��ϰ� �ʹ�.
public class EnemyHP : MonoBehaviour
{
    int hp;
    public int maxHP = 2;
    public Slider sliderHP;
    public static EnemyHP instance;

    private void Awake()
    {
        instance = this;
    }
    public int HP
    {
        set
        {
            hp = value;
            sliderHP.value = hp;
        }

        get
        {
            return hp;
        }
    }
    void Start()
    {
        sliderHP.maxValue = maxHP;
        HP = maxHP;
    }

}
