using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ҷ��� �����Ǹ� ���� �߻��ϰ� �ʹ�.
public class P_Bullet : MonoBehaviour
{
    // �߻�ӵ�
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���� �߻��ϰ� �ʹ�.
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
