using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���� �̵��ϰ� �ʹ�.
public class Bullet : MonoBehaviour
{
    public float speed = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���� �̵��ϰ� �ʹ�.
        transform.position += transform.up * speed * Time.deltaTime;


    }
}
