using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�¾�� �������� �̵��ϰ�ʹ�.
//�̵��� ������ �����ϰ�ʹ�.
//������ ������ 3�� ����ϰ� ���ð��� ������ �ٽ� �����ϰ�ʹ�.
// ���ݰ� ��⸦ �ݺ��ϰ�ʹ�.
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
        // ����� ���
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
        // �ð��� �帣�ٰ�
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


        // angle 360�̶��
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
