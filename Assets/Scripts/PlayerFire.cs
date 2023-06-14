using UnityEngine;

//����ڰ� ���콺 ���� ��ư�� ������
//�Ѿ˰��忡�� �Ѿ��� ����
//�ѱ���ġ�� ��ġ�ϰ� �ʹ�.
//���콺 ���� ��ư�� ������ ������ 0.2�ʸ��� �Ѿ��� ��� �߻�ǰ� �ϰ�ʹ�.
// ��ư�� ���� �׸� �߻��ϰ� �ϰ� �ʹ�.
public class PlayerFire : MonoBehaviour
{

    public GameObject bulletFactory;
    public Transform firePosition;

    bool bAutoFire;
    float currentTime;
    public float fireTime = 0.2f;

    void Start()
    {

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
        //�Ѿ˰��忡�� �Ѿ��� ����
        GameObject bullet = Instantiate(bulletFactory);
        //�ѱ���ġ�� ��ġ�ϰ� �ʹ�.
        bullet.transform.position = firePosition.position;

    }
}
