using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Speed;
    public float JumpForce;
    private Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = new Vector2(Speed, rigid.velocity.y);
        if(Input.GetMouseButtonDown(0)) //Checa clique no botão esquerdo do mouse
        {
            rigid.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }
    }
}
