using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Transform���ε� spawn ����� ������ �ְ�ʹ�.
// �����ð����� spawn ����߿� �������� �ϳ� ���ϰ� �ʹ�.
// �� ���忡�� ���� ���� �� ��ġ�� ��ġ�ϰ� �ʹ�.
public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;

    public Transform[] spawnList;
    float currentTime;
    public float makeTime = 1f;
    GameObject enemyFactory;
    int prevChooseIndex = -1;

    public bool isBoss;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        enemyFactory = Resources.Load<GameObject>("Enemy");
    }

    private void Update()
    {

        if (isBoss)
        {
            UpdateBoss();
        }
        else
        {
            UpdateNormal(); 
        }
    }

    // ȭ�鿡 ���� ���忡�� �ϳ��� ��������� �ϰ�ʹ�.
    private void UpdateBoss()
    {

    }
    private void UpdateNormal()
    {
        // �����ð����� spawn ����߿� �������� �ϳ� ���ϰ� �ʹ�.
        // �� ���忡�� ���� ���� �� ��ġ�� ��ġ�ϰ� �ʹ�.
        // �ð��� �帣�ٰ�
        currentTime += Time.deltaTime;
        // ����ð��� �����ð��� �Ǹ�
        if (currentTime > makeTime)
        {
            // �� ���忡�� ���� ����
            GameObject enemy = Instantiate(enemyFactory);
            // spawn ����߿� �������� ���� ���� �� ��ġ�� ��ġ�ϰ�ʹ�.
            // ���� �͵����� ���� �ε����� ���ٸ� �ٽ� ���ϰ�ʹ�.
            int chooseIndex = Random.Range(0, spawnList.Length);
            if (prevChooseIndex == chooseIndex)
            {
                //chooseIndex = (chooseIndex + 1) % spawnList.Length;
                //chooseIndex = (chooseIndex + spawnList.Length - 1) % spawnList.Length;
               //�Ųٷ� �ϰ�ʹ�.
              // �ٽ� ���ϰ� �ʹ�.
                chooseIndex++;
                // ���� �迭�� ������ ����ٸ� 0���� �ʱ�ȭ �ϰ�ͤ���.
                if (chooseIndex >= spawnList.Length)
                {
                    chooseIndex = 0;
                }
            }
            // ���� �ε����� ���� �ε����� ����ϰ� �ʹ�.
            prevChooseIndex = chooseIndex;

            enemyFactory.transform.position = spawnList[chooseIndex].transform.position;
            // ���� �ð��� 0���� �ʱ�ȭ �ϰ�ʹ�.
            currentTime = 0;
        }
    }
}
