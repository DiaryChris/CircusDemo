using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public int Hp = 1;
    public float Horizontal;
    public bool IsKeyUp;
    public BgControl BgControl;

    private Animator ani;
    private Rigidbody2D rBody;

    private bool isGround = true;


    // Use this for initialization
    void Start()
    {
        ani = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Hp <= 0)
        {
            return;
        }

        Horizontal = Input.GetAxis("Horizontal");
        IsKeyUp = Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow);

        //水平按键且成功Move则播放Run动画
        if (Horizontal != 0 && BgControl.Move(Horizontal))
        {
            ani.SetBool("IsRun", true);
        }
        else
        {
            ani.SetBool("IsRun", false);
        }

        //向上按键且在地面上则跳跃
        if (IsKeyUp && isGround)
        {
            rBody.AddForce(Vector2.up * 300);
            AudioManager.Instance.PlayJump();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGround = true;
            ani.SetBool("IsJump", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGround = false;
            ani.SetBool("IsJump", true);
        }
    }

    private void OnTriggerEnter2D()
    {
        Hp--;
        Destroy(rBody);
        ani.SetBool("IsDie", true);
        AudioManager.Instance.PlayCrash();
    }
}
