using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �¾ �� ������ ���ϰ� �ʹ�.
// 30������ Ȯ���� �÷��̾� ����, ������ Ȯ���� �Ʒ��� ���ϰ� �ʹ�.
// ��ư��鼭 �� �������� �̵��ϰ� �ʹ�.
// Enemy�� �ı��� �� ���߰��忡�� ������ ���� ����ġ�� ��ġ�ϰ�ʹ�. ������ 2�� �Ŀ� �ı��ǰ� �ϰ�ʹ�.
public class Enemy : MonoBehaviour
{
    public GameObject explosionFactory;
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
            transform.up = -dir;
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
                // ���ӿ���UI�� Ȱ��ȭ �ϰ�ʹ�.
                GameManager.instance.gameOverUI.SetActive(true);
            }


        }
        else
        {

            collision.gameObject.SetActive(false);
            PlayerFire.deActiveBulletObjectPool.Add(collision.gameObject);

        }
        // ������ 1�� ������Ű�� �ʹ�.
        ScoreManager.instance.SCORE++;

        // enemyHP ü���� 1 �����ϰ�ʹ�.
        // ü���� 0���϶��
        // ������ �ϰ�ʹ�.
        EnemyHP.instance.HP--;
        if (EnemyHP.instance.HP <= 0)
        {

            Destroy(this.gameObject);

            PlayerLevel.instance.EXP++;

            // Enemy�� �ı��� �� ���߰��忡�� ������ ����
            GameObject explosion = Instantiate(explosionFactory);
            // ����ġ�� ��ġ�ϰ�ʹ�.
            explosion.transform.position = transform.position;
            // ������ 2�� �Ŀ� �ı��ǰ� �ϰ�ʹ�.
            Destroy(explosion, 2);
        }

    }
}
