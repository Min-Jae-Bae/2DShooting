using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� �Է¿� ���� �����¿�� �̵��ϰ�ʹ�.
// �ʿ���
// �ӷ�
public class PlayerMove : MonoBehaviour
{
    float speed = 5;

    void Start()
    {

    }

    void Update()
    {
        //1.������� �Է¿� ����
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //2.�����¿�� ������ �����
        Vector3 dir = new Vector3(h, v, 0);

        //dir�� ũ�⸦ 1�� �����ʹ�.
        dir.Normalize();

        //3.�� �������� �̵��ϰ� �ʹ�.
        transform.position += dir * speed * Time.deltaTime;

    }
}
