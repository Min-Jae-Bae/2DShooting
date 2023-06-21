using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���������� ������ ���ϸ� ��� ��ũ�� �ӵ��� ������ �ϰ�ͤ���.
public class StageLevel : MonoBehaviour
{
    public static StageLevel instance;
    public int level;
    public Background bg;

    private void Awake()
    {
        instance = this;
    }

    public int LEVEL
    {
        set
        {
            level = value;
            //�������� ������ 2���Ǹ�
            if (level == 2)
            {
                // ��� ��ũ�� �ӵ��� 2�� ������ �ϰ�ʹ�.
                bg.speed = 2f;
                // ������ �����ǰ� �ϰ�ʹ�.
                SpawnManager.instance.isBoss = true;
            }

        }
        get
        {
            return level;
        }
    }
    private void Start()
    {

    }
}
