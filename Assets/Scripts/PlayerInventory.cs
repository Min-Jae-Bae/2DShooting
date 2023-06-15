using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//포션 아이템과 부딪혔다면 포션갯수 1증가시키고 싶다.
//만약 1번 키를 눌렀는데 포션이 1개 이상 있다면 체력을 최대체력으로 하고싶다.
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
        //만약 부딪힌 상대가 Item이라면
        if (other.gameObject.CompareTag("Item"))
        {
            // 포션갯수를 1개 증가시키고 UI도 표현하고싶다.
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
        //만약 1번 키를 눌렀는데
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
        //만약 포션이 1개 이상 있다면
            if (POTION > 0)
            {
                // 체력을 최대체력으로 하고 싶다.
                playerHp.HP = playerHp.maxHp;
                // 4. 포션을 1 감소하고싶다.
                POTION--;
            }
        }
    }
}
