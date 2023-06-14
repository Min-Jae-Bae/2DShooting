using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//위로 이동하고 싶다.
public class Bullet : MonoBehaviour
{
    public float speed = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //위로 이동하고 싶다.
        transform.position += transform.up * speed * Time.deltaTime;


    }
}
