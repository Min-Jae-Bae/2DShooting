using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ҷ��� �� �������� �̵���Ű�� �ʹ�.
public class T_Bullet : MonoBehaviour
{
    //�̵� �ӵ�
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
