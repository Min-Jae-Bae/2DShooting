using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 플레이 방향으로 앞에다가 놓고 싶다.
public class T_PlayerFire : MonoBehaviour
{
    // 넣을 위치
    public GameObject firePosition;
    // 불렛 공장
    public GameObject bulletFactory;
    void Start()
    {
        
    }

    void Update()
    {
        // 플레이어가 fire 1을 눌렀을 때 앞에다가 놓는다.
        if (Input.GetButtonDown("Fire1"))
        {
            // 불렛 공장을 초기화한다.
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = firePosition.transform.position;
        }
    }
}
