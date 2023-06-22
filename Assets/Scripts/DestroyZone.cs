using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//누군가와 감지충돌 되면 상대방을 파괴하고 싶다.

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            //총알은 objectpool로 되어있으니 파괴하지 않고 비활성화 한다.
            other.gameObject.SetActive(false);
            //비활성 목록에 다시 추가한다.
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
