using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�÷��̾��� �����¿� ������ �ϰ�ʹ�.
public class P_PlayerMove : MonoBehaviour
{
    // �̵��ϰ� ������ �ӵ��� �ʿ��ϴ�.
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �����¿� Ű�� �־�� �Ѵ�.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // ���� �¿츦 ���� ������ �����. // 2D = x�ϰ� y��
        Vector3 dir = new Vector3(h, v, 0);

        // �÷��̾� ��ġ�� ���� �¿츦 �����δ�.
        transform.position += dir * speed * Time.deltaTime;
    }
}
