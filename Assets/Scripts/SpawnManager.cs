using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Transform으로된 spawn 목록을 가지고 있고싶다.
// 일정시간마다 spawn 목록중에 랜덤으로 하나 정하고 싶다.
// 적 공장에서 적을 만들어서 그 위치에 배치하고 싶다.
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

    // 화면에 강적 공장에서 하나만 만들어지게 하고싶다.
    private void UpdateBoss()
    {

    }
    private void UpdateNormal()
    {
        // 일정시간마다 spawn 목록중에 랜덤으로 하나 정하고 싶다.
        // 적 공장에서 적을 만들어서 그 위치에 배치하고 싶다.
        // 시간이 흐르다가
        currentTime += Time.deltaTime;
        // 현재시간이 생성시간이 되면
        if (currentTime > makeTime)
        {
            // 적 공장에서 적을 만들어서
            GameObject enemy = Instantiate(enemyFactory);
            // spawn 목록중에 랜덤으로 정한 곳에 내 위치에 배치하고싶다.
            // 랜덤 익데스가 직전 인덱스와 같다면 다시 정하고싶다.
            int chooseIndex = Random.Range(0, spawnList.Length);
            if (prevChooseIndex == chooseIndex)
            {
                //chooseIndex = (chooseIndex + 1) % spawnList.Length;
                //chooseIndex = (chooseIndex + spawnList.Length - 1) % spawnList.Length;
               //거꾸로 하고싶다.
              // 다시 정하고 싶다.
                chooseIndex++;
                // 만약 배열의 범위를 벗어난다면 0으로 초기화 하고싶ㅍ다.
                if (chooseIndex >= spawnList.Length)
                {
                    chooseIndex = 0;
                }
            }
            // 직전 인덱스에 현재 인덱스를 기억하고 싶다.
            prevChooseIndex = chooseIndex;

            enemyFactory.transform.position = spawnList[chooseIndex].transform.position;
            // 현재 시간을 0으로 초기화 하고싶다.
            currentTime = 0;
        }
    }
}
