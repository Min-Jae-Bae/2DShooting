using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���� up �������� �̵��ϰ� �ʹ�.
// ȭ������� �����ԵǴ� ��� ������ �������� 90�� ȸ���ϰ�ʹ�.
public class Item : MonoBehaviour
{
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���� up �������� �̵��ϰ� �ʹ�.
        transform.position += transform.up * speed * Time.deltaTime;
        // ȭ������� �����ԵǴ� ��� ������ �������� 90�� ȸ���ϰ�ʹ�.
        Vector3 viewportPoint = Camera.main.WorldToViewportPoint(transform.position);
        if (viewportPoint.x <= 0 || viewportPoint.x >= 1 || viewportPoint.y <= 0 || viewportPoint.y >= 1)
        {
            transform.up = transform.right;
        }
    }
}
