using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �¾ �� ������ ���ϰ� �ʹ�.
// 30������ Ȯ���� �÷��̾� ����, ������ Ȯ���� �Ʒ��� ���ϰ� �ʹ�.
// ��ư��鼭 �� �������� �̵��ϰ� �ʹ�.
public class Enemy : MonoBehaviour
{

    Vector3 dir;

    public float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        // �¾ �� ������ ���ϰ� �ʹ�.
        int rValue = Random.Range(0, 10);
        // 30������ Ȯ���� �÷��̾� ����, ������ Ȯ���� �Ʒ��� ���ϰ� �ʹ�.
        if (rValue < 3)
        {
            //�÷��̾� ����
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - this.transform.position;
            // �������ͷ� ũ�� 1 ����
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //���� �Ʒ��� �̵��ϴ� ������ ������ - p0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ���� �ε��� ������ �̸��� enemy��� ���ڿ��� ���ԵǾ��ִٸ�
        // ü���� 1 �����ϰ� �ʹ�.
        if (collision.gameObject.name.Contains("Player"))
        {
 
            //ü���� 1 �����ϰ� �ʹ�.
           PlayerHP.instance.HP--;
            if (PlayerHP.instance.HP <= 0)
            {
                //���װ�
                Destroy(collision.gameObject);

            }
        }
        // ������ 1�� ������Ű�� �ʹ�.
        ScoreManager.instance.SCORE++;
        // ��: enemy, ��: Bullet
        //������
        Destroy(this.gameObject);


    }
}
