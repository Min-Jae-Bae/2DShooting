using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//불렛을 위 방향으로 이동시키고 싶다.
public class T_Bullet : MonoBehaviour
{
    //이동 속도
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
