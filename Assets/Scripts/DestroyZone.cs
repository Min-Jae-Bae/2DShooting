using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//누군가와 감지충돌 되면 상대방을 파괴하고 싶다.

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
