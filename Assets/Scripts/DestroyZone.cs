using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�������� �����浹 �Ǹ� ������ �ı��ϰ� �ʹ�.

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            //�Ѿ��� objectpool�� �Ǿ������� �ı����� �ʰ� ��Ȱ��ȭ �Ѵ�.
            other.gameObject.SetActive(false);
            //��Ȱ�� ��Ͽ� �ٽ� �߰��Ѵ�.
            PlayerFire.deActiveBulletObjectPool.Add(other.gameObject);
        }
        else
        {
            Destroy(other.gameObject); 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
