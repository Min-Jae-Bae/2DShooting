using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 태어날 때 체력을 최대체력으로 하고싶다. UI도 처리하고 싶다.
// 총알 혹은 플레이어와 부딪힐 때 체력을 1 감소하고싶다. 체력이 0이되면 파괴하고 싶다.
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
