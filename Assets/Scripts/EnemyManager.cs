using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ð��� �帣�ٰ� �����ð��� �Ǹ� ���忡�� ���� ���� ��ġ����
public class EnemyManager : MonoBehaviour
{
    //���� �ð�
    float currentTime = 0f;
    //���� �ð�
    public float makeTime = 2f;
    //������
    public GameObject enemyFactory;

    void Start()
    {

    }

    void Update()
    {

        // �ð��� �帣�ٰ�
        currentTime += Time.deltaTime;

        // �����ð��� �Ǹ� ���忡��
        if (currentTime > makeTime)
        {
            // �� ������ ������
            GameObject enemy = Instantiate(enemyFactory);
            // ���� ���� �Ŵ��� ��ġ�� ��ġ����
            enemy.transform.position = transform.position;
            //���� ��ġ�� �� �������� ��ġ�ϰ� �ʹ�.
            enemy.transform.rotation = transform.rotation;
            // ���� �ð��� �ʱ�ȭ����
            currentTime = 0;

        }

    }
}
