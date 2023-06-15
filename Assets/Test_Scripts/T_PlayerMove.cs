using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 플레이어를 상하좌우 조작해서 움직이고 싶다.
public class T_PlayerMove : MonoBehaviour
{
    // 속도
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, v, 0);

        transform.position += dir * speed * Time.deltaTime;
    }
}
