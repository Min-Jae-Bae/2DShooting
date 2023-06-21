using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스테이지의 레벨이 변하면 배경 스크롤 속도를 빠르게 하고싶ㅍ다.
public class StageLevel : MonoBehaviour
{
    public static StageLevel instance;
    public int level;
    public Background bg;

    private void Awake()
    {
        instance = this;
    }

    public int LEVEL
    {
        set
        {
            level = value;
            //스테이지 레벨이 2가되면
            if (level == 2)
            {
                // 배경 스크롤 속도를 2배 빠르게 하고싶다.
                bg.speed = 2f;
                // 보스가 생성되게 하고싶다.
                SpawnManager.instance.isBoss = true;
            }

        }
        get
        {
            return level;
        }
    }
    private void Start()
    {

    }
}
