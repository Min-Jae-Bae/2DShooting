using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�������� �����浹 �Ǹ� ������ �ı��ϰ� �ʹ�.

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
