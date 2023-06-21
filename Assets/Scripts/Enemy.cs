using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 태어날 때 방향을 정하고 싶다.
// 30프로의 확률로 플레이어 방향, 나머지 확률로 아래로 정하고 싶다.
// 살아가면서 그 방향으로 이동하고 싶다.
// Enemy가 파괴될 때 폭발공장에서 폭발을 만들어서 내위치에 배치하고싶다. 폭발은 2초 후에 파괴되게 하고싶다.
public class Enemy : MonoBehaviour
{
    public GameObject explosionFactory;
    Vector3 dir;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // 태어날 때 방향을 정하고 싶다.
        int rValue = Random.Range(0, 10);
        // 30프로의 확률로 플레이어 방향, 나머지 확률로 아래로 정하고 싶다.
        if (rValue < 3)
        {
            //플레이어 방향
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - this.transform.position;
            // 단위벡터로 크기 1 지정
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
        //적을 아래로 이동하는 방향을 만들어라 - p0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 만약 부딪힌 상대방의 이름에 enemy라는 문자열이 포함되어있다면
        // 체력을 1 감소하고 싶다.
        if (collision.gameObject.name.Contains("Player"))
        {

            //체력을 1 감소하고 싶다.
            PlayerHP.instance.HP--;
            if (PlayerHP.instance.HP <= 0)
            {
                //너죽고
                Destroy(collision.gameObject);
                // 게임오버UI를 활성화 하고싶다.
                GameManager.instance.gameOverUI.SetActive(true);
            }


        }
        else
        {

            collision.gameObject.SetActive(false);
            PlayerFire.deActiveBulletObjectPool.Add(collision.gameObject);

        }
        // 점수를 1점 증가시키고 싶다.
        ScoreManager.instance.SCORE++;

        // enemyHP 체력을 1 감소하고싶다.
        // 체력이 0이하라면
        // 나죽자 하고싶다.
        EnemyHP.instance.HP--;
        if (EnemyHP.instance.HP <= 0)
        {

            Destroy(this.gameObject);

            PlayerLevel.instance.EXP++;

            // Enemy가 파괴될 때 폭발공장에서 폭발을 만들어서
            GameObject explosion = Instantiate(explosionFactory);
            // 내위치에 배치하고싶다.
            explosion.transform.position = transform.position;
            // 폭발은 2초 후에 파괴되게 하고싶다.
            Destroy(explosion, 2);
        }

    }
}
