using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 태어날때 체력을 최대 체력으로 하고싶다. 그리고 화면에 표현하고 싶다.
// 적과 플레이어가 충돌했을 때 체력을 1 감소하고 싶다.
// 체력이 0이 되었을 때 게임오버 처리하고 싶다.
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
        // 태어날 때 최대 체력으로 하고 싶다.
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
