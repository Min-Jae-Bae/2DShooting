using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �Ѿ��� �߻��ϰ� �ʹ�.
public class P_PlayerFire : MonoBehaviour
{
    // �Ѿ� ����
    public GameObject bulletFactory;
    // �߻� ��ġ
    public Transform firePosition;

    void Start()
    {
        
    }

    void Update()
    {
        // ���� ���콺�� Ŭ���ϸ� �Ѿ� ���忡�� �Ѿ��� �߻��Ѵ�.
        if (Input.GetButtonDown("Fire1"))
        {
            // �Ѿ� ������ �����Ѵ�.
            GameObject bullet = Instantiate(bulletFactory);

            bullet.transform.position = firePosition.position;
        }
    }
}
