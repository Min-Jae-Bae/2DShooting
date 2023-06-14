using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//플레이어의 상하좌우 조작을 하고싶다.
public class P_PlayerMove : MonoBehaviour
{
    // 이동하고 싶으면 속도가 필요하다.
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 상하좌우 키가 있어야 한다.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 상하 좌우를 향한 방향을 만든다. // 2D = x하고 y만
        Vector3 dir = new Vector3(h, v, 0);

        // 플레이어 위치를 상하 좌우를 움직인다.
        transform.position += dir * speed * Time.deltaTime;
    }
}
