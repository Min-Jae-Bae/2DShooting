using System;
using System.Collections.Generic;
using UnityEngine;

//����ڰ� ���콺 ���� ��ư�� ������
//�Ѿ˰��忡�� �Ѿ��� ����
//�ѱ���ġ�� ��ġ�ϰ� �ʹ�.
//���콺 ���� ��ư�� ������ ������ 0.2�ʸ��� �Ѿ��� ��� �߻�ǰ� �ϰ�ʹ�.
//ObjectPool ó���ϰ� �ʹ�.=============================================== 
//�¾ �� �Ѿ��� �̸� ���� �Ѿ˸�Ͽ� ����ϰ� ��Ȱ��ȭ �س���
//�Ѿ� ����� ���� �Ѿ��� �߻�ɶ� ��Ͽ��� �ϳ� �����ͼ� Ȱ��ȭ �ϰ�ʹ�.
//�Ѿ��� ȭ�� �ۿ� ������ ���� �ε����� �� ��Ȱ��ȭ �ϰ�ʹ�.
//��Ȱ��ȭ ����� ���� ��Ȱ�� �Ѿ��� �˻��ϴ� ���� �����ʰ� �ʹ�.
public class PlayerFire : MonoBehaviour
{
    List<GameObject> bulletObjectPool;
    int bulletObjectPoolCount = 5;
    public static List<GameObject> deActiveBulletObjectPool;
    public Transform bulletParent;

    public List<GameObject> DeActiveBulletObjectPool
    {
        get { return deActiveBulletObjectPool; }
    }

    public GameObject bulletFactory;
    public Transform firePosition;

    bool bAutoFire;
    float currentTime;
    public float fireTime = 0.2f;


    void Start()
    {
        //�¾ �� �Ѿ��� �̸� ���� �Ѿ˸�Ͽ� ����ϰ� ��Ȱ��ȭ �س���
        bulletObjectPool = new List<GameObject>();
        deActiveBulletObjectPool = new List<GameObject>();
        for (int i = 0; i < bulletObjectPoolCount; i++)
        {
            GameObject bullet = Instantiate(bulletFactory);
            // bullet�� �θ� = bulletParent
            bullet.transform.SetParent(bulletParent);
            bullet.SetActive(false);
            bulletObjectPool.Add(bullet);
            deActiveBulletObjectPool.Add(bullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (bAutoFire)
        {
            // ������ ��
            // �ð��� �帣�ٰ�
            currentTime += Time.deltaTime;
            // �Ѿ˻����ð��� �Ǹ�
            if (currentTime > fireTime)
            {
                // �Ѿ��� ����ڴ�.
                MakeBullet();
                currentTime = 0;

            }

        }
        //����ڰ� ���콺 ���� ��ư�� ������
        if (Input.GetButtonDown("Fire1"))
        {
            bAutoFire = true;
            MakeBullet();
            currentTime = 0;
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            bAutoFire = false;
        }
    }

    void MakeBullet()
    {
        //�Ѿ� ����� ���� �Ѿ� ��Ͽ��� ��Ȱ��ȭ�� �Ѿ��� �ϳ� �����ͼ�  Ȱ��ȭ �ϰ�ʹ�.
        GameObject bullet = GetBulletFromObjectPool();
        //�ѱ���ġ�� ��ġ�ϰ� �ʹ�.
        if (bullet != null)
        {
            bullet.transform.position = firePosition.position;
            bullet.transform.up = transform.up; 
        }

    }

    GameObject GetBulletFromObjectPool()
    {
        // ���� ��Ȱ��ȭ��Ͽ� ũ�Ⱑ 0���� ũ�ٸ�
        if (DeActiveBulletObjectPool.Count > 0)
        {
            // ��Ȱ��ȭ����� 0��° �׸��� ��ȯ�ϰ�ʹ�.
            GameObject bullet = DeActiveBulletObjectPool[0];
            bullet.SetActive(true);
            // ��Ͽ��� �ҷ��� ����� �ʹ�.
            DeActiveBulletObjectPool.Remove(bullet);
            return bullet;
        }
        // �׷��� �ʴٸ� null�� ��ȯ�ϰ�ʹ�.
        return null;
    }
}
