using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2초의 시간이 지나면 enemy 공장에서 적을 플레이어 방향으로 만들고 싶다.
public class P_EnemyManager : MonoBehaviour
{
    // 적 공장
    public GameObject enemyFactory;
    // 현재시간
    float currentTime = 0;
    // 최대 시간
    float createTime = 2f;


    void Update()
    {

        // 시간을 점점 추가하여
        currentTime += Time.deltaTime;
        // 생성시간이 되면
        if (currentTime > createTime)
        {
            // 적 공장에서 적을 생성하고
            GameObject enemy = Instantiate(enemyFactory);
            // 적 공장 생성 위치를 enemy 위치에 놓는다
            enemy.transform.position = transform.position;
            // 적 공장 회전 방향을 enemy 위치에 놓는다.
            enemy.transform.rotation = transform.rotation;
            // 시간을 초기화한다.
            currentTime = 0;
        }
    }
}
