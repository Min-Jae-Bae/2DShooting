using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2���� �ð��� ������ enemy ���忡�� ���� �÷��̾� �������� ����� �ʹ�.
public class P_EnemyManager : MonoBehaviour
{
    // �� ����
    public GameObject enemyFactory;
    // ����ð�
    float currentTime = 0;
    // �ִ� �ð�
    float createTime = 2f;


    void Update()
    {

        // �ð��� ���� �߰��Ͽ�
        currentTime += Time.deltaTime;
        // �����ð��� �Ǹ�
        if (currentTime > createTime)
        {
            // �� ���忡�� ���� �����ϰ�
            GameObject enemy = Instantiate(enemyFactory);
            // �� ���� ���� ��ġ�� enemy ��ġ�� ���´�
            enemy.transform.position = transform.position;
            // �� ���� ȸ�� ������ enemy ��ġ�� ���´�.
            enemy.transform.rotation = transform.rotation;
            // �ð��� �ʱ�ȭ�Ѵ�.
            currentTime = 0;
        }
    }
}
