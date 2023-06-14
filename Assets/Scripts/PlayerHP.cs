using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// �¾�� ü���� �ִ� ü������ �ϰ�ʹ�. �׸��� ȭ�鿡 ǥ���ϰ� �ʹ�.
// ���� �÷��̾ �浹���� �� ü���� 1 �����ϰ� �ʹ�.
// ü���� 0�� �Ǿ��� �� ���ӿ��� ó���ϰ� �ʹ�.
public class PlayerHP : MonoBehaviour
{
    int hp;
    public int maxHp = 3;

    public Slider sliderHP;
    public static PlayerHP instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        // �¾ �� �ִ� ü������ �ϰ� �ʹ�.
        sliderHP.maxValue = maxHp;
        HP = maxHp;
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

}
