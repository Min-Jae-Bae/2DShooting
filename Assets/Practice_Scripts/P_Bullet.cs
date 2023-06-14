using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 불렛이 생성되면 위로 발사하고 싶다.
public class P_Bullet : MonoBehaviour
{
    // 발사속도
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 위로 발사하고 싶다.
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
