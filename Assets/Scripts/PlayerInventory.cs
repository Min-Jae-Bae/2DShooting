using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//���� �����۰� �ε����ٸ� ���ǰ��� 1������Ű�� �ʹ�.
//���� 1�� Ű�� �����µ� ������ 1�� �̻� �ִٸ� ü���� �ִ�ü������ �ϰ�ʹ�.
public class PlayerInventory : MonoBehaviour
{
    int potion;
    public TextMeshProUGUI textPotion;

    public int POTION
    {
        set
        {
            potion = value;
            textPotion.text = "x " + potion;
        }
        get
        {
            return potion;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //���� �ε��� ��밡 Item�̶��
        if (other.gameObject.CompareTag("Item"))
        {
            // ���ǰ����� 1�� ������Ű�� UI�� ǥ���ϰ�ʹ�.
            POTION++;
            Destroy(other.transform.parent.gameObject);
        }
    }

    PlayerHP playerHp;
    private void Start()
    {
        playerHp = GetComponent<PlayerHP>();
    }
    private void Update()
    {
        //���� 1�� Ű�� �����µ�
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
        //���� ������ 1�� �̻� �ִٸ�
            if (POTION > 0)
            {
                // ü���� �ִ�ü������ �ϰ� �ʹ�.
                playerHp.HP = playerHp.maxHp;
                // 4. ������ 1 �����ϰ�ʹ�.
                POTION--;
            }
        }
    }
}
