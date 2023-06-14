using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��ǥ�� ���� �̵��ϰ�ʹ�.
public class Tail : MonoBehaviour
{
    public GameObject target;
    //�ӵ�
    public float speed = 4.5f;

    //����
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1. ��ǥ�� ���ϴ� ������ ���ϰ� �ʹ�. (��ǥ���� ���� ����)
        direction = target.transform.position - this.transform.position;

        //ũ�⸦ 1�� �����.
        direction.Normalize();
        
        //2. �� �������� �̵��ϰ� �ʹ�.
        transform.position += direction * speed * Time.deltaTime;
    }
}
