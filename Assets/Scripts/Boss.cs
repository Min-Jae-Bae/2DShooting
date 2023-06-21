using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//태어나면 목적지로 이동하고싶다.
//이동이 끝나면 공격하고싶다.
//공격이 끝나면 3초 대기하고 대기시간이 끝나면 다시 공격하고싶다.
// 공격과 대기를 반복하고싶다.
public class Boss : MonoBehaviour
{
    const int MOVE = 0;
    const int ATTACK = 1;
    const int WAIT = 2;

    float speed = 5f;
    int state;
    public Transform moveTarget;

    public GameObject bossBulletFactory;
    float angleZ;

    private void Start()
    {
        // 명시적 방법
        state = MOVE;
    }

    private void Update()
    {
        switch (state)
        {
            case MOVE:
                UpdateMove();
                break;
            case ATTACK:
                UpdateAttack();
                break;
            case WAIT:
                UpdateWait();
                break;
        }
    }

    float currentTime = 0;
    public float waitTime = 3;
    public float bulletCount = 12;
    public float fireTime = 0.1f;
    private void UpdateWait()
    {
        // 시간이 흐르다가
        currentTime += Time.deltaTime;
        if (currentTime > waitTime)
        {
            state = ATTACK;
            currentTime = 0;
        }
    }

    private void UpdateAttack()
    {
        currentTime += Time.deltaTime;
        if (currentTime > fireTime)
        {
            GameObject bullet = Instantiate(bossBulletFactory);
            bullet.transform.position = transform.position;
            bullet.transform.eulerAngles = new Vector3(0, 0, angleZ);
            angleZ += 360 / bulletCount;
        }


        // angle 360이라면
        if (angleZ >= 360)
        {
            state = WAIT;
            currentTime = 0;
            angleZ = 0;
        }

    }

    private void UpdateMove()
    {
        Vector3 dir = moveTarget.position - transform.position;

        transform.position += dir.normalized * speed * Time.deltaTime;
        if (dir.magnitude < 0.1f)
        {
            transform.position = moveTarget.position;
            state = ATTACK;
        }

        state = WAIT;
    }
}
