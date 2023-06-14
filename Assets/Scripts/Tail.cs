using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//목표를 향해 이동하고싶다.
public class Tail : MonoBehaviour
{
    public GameObject target;
    //속도
    public float speed = 4.5f;

    //방향
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1. 목표를 향하는 방향을 구하고 싶다. (목표에서 나를 뺀다)
        direction = target.transform.position - this.transform.position;

        //크기를 1로 만든다.
        direction.Normalize();
        
        //2. 그 방향으로 이동하고 싶다.
        transform.position += direction * speed * Time.deltaTime;
    }
}
