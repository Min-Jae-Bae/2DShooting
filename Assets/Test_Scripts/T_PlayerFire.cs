using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �÷��� �������� �տ��ٰ� ���� �ʹ�.
public class T_PlayerFire : MonoBehaviour
{
    // ���� ��ġ
    public GameObject firePosition;
    // �ҷ� ����
    public GameObject bulletFactory;
    void Start()
    {
        
    }

    void Update()
    {
        // �÷��̾ fire 1�� ������ �� �տ��ٰ� ���´�.
        if (Input.GetButtonDown("Fire1"))
        {
            // �ҷ� ������ �ʱ�ȭ�Ѵ�.
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = firePosition.transform.position;
        }
    }
}
