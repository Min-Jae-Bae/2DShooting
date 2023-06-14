using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 시간이 흐르다가 생성시간이 되면 공장에서 적을 만들어서 배치하자
public class EnemyManager : MonoBehaviour
{
    //현재 시간
    float currentTime = 0f;
    //생성 시간
    public float makeTime = 2f;
    //적공장
    public GameObject enemyFactory;

    void Start()
    {

    }

    void Update()
    {

        // 시간이 흐르다가
        currentTime += Time.deltaTime;

        // 생성시간이 되면 공장에서
        if (currentTime > makeTime)
        {
            // 적 공장을 만들자
            GameObject enemy = Instantiate(enemyFactory);
            // 적을 만들어서 매니지 위치에 배치하자
            enemy.transform.position = transform.position;
            //적의 위치를 내 방향으로 배치하고 싶다.
            enemy.transform.rotation = transform.rotation;
            // 생성 시간을 초기화하자
            currentTime = 0;

        }

    }
}
