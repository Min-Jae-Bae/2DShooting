using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 총알을 발사하고 싶다.
public class P_PlayerFire : MonoBehaviour
{
    // 총알 공장
    public GameObject bulletFactory;
    // 발사 위치
    public Transform firePosition;

    void Start()
    {
        
    }

    void Update()
    {
        // 왼쪽 마우스를 클릭하면 총알 공장에서 총알을 발사한다.
        if (Input.GetButtonDown("Fire1"))
        {
            // 총알 공장을 생성한다.
            GameObject bullet = Instantiate(bulletFactory);

            bullet.transform.position = firePosition.position;
        }
    }
}
