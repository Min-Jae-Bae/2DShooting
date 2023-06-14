using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 적이 태어났을 때 30프로의 확률오 플레이어 이동 방향으로 이동하고 싶다.
public class P_Enemy : MonoBehaviour
{
    // 이동 방향
    Vector3 dir;
    // 적의 이동 속도
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        // 30프로의 확률
        int randomValue = Random.Range(0, 10);
        if (randomValue < 3)
        {
            // 플레이어의 위치를 찾는다.
            GameObject target = GameObject.Find("Player");
            // 플레이어의 위치 방향을 만든다.
            dir = target.transform.position - transform.position;
            // 크기를 초기화 한다.
            dir.Normalize();
        }
        else
        {
            // 아닐 시에는 밑 방향으로 이동한다.
            dir += Vector3.down;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        // 적을 이동 시킨다.
        transform.position += dir * speed * Time.deltaTime;
    }

    // 충돌 했을 때 적이랑 나를 삭제한다.
    private void OnCollisionEnter(Collision collision)
    {
        // 적을 삭제한다.
        Destroy(collision.gameObject);
        // 나를 삭제한다.
        Destroy(gameObject);
    }
}
