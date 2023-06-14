using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �¾�� �� 30������ Ȯ���� �÷��̾� �̵� �������� �̵��ϰ� �ʹ�.
public class P_Enemy : MonoBehaviour
{
    // �̵� ����
    Vector3 dir;
    // ���� �̵� �ӵ�
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        // 30������ Ȯ��
        int randomValue = Random.Range(0, 10);
        if (randomValue < 3)
        {
            // �÷��̾��� ��ġ�� ã�´�.
            GameObject target = GameObject.Find("Player");
            // �÷��̾��� ��ġ ������ �����.
            dir = target.transform.position - transform.position;
            // ũ�⸦ �ʱ�ȭ �Ѵ�.
            dir.Normalize();
        }
        else
        {
            // �ƴ� �ÿ��� �� �������� �̵��Ѵ�.
            dir += Vector3.down;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���� �̵� ��Ų��.
        transform.position += dir * speed * Time.deltaTime;
    }

    // �浹 ���� �� ���̶� ���� �����Ѵ�.
    private void OnCollisionEnter(Collision collision)
    {
        // ���� �����Ѵ�.
        Destroy(collision.gameObject);
        // ���� �����Ѵ�.
        Destroy(gameObject);
    }
}
