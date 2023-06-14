using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자의 입력에 따라 상하좌우로 이동하고싶다.
// 필요요소
// 속력
public class PlayerMove : MonoBehaviour
{
    float speed = 5;

    void Start()
    {

    }

    void Update()
    {
        //1.사용자의 입력에 따라
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //2.상하좌우로 방향을 만들고
        Vector3 dir = new Vector3(h, v, 0);

        //dir의 크기를 1로 만들고싶다.
        dir.Normalize();

        //3.그 방향으로 이동하고 싶다.
        transform.position += dir * speed * Time.deltaTime;

    }
}
