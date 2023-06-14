    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���� ��ũ�� �ϰ�ʹ�.
public class Background : MonoBehaviour
{
    public float speed = 0.1f;
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        // �¾ �� �������� �����ͼ� ����ϰ� �ʹ�.
        renderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
