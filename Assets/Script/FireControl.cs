using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControl : MonoBehaviour
{

    private PlayerControl pc;
    private BgControl bc;

    private float FireSpeed = 0.8f;
    private float relativeSpeed;

    // Use this for initialization
    void Start()
    {
        pc = GameObject.FindWithTag("Player").GetComponent<PlayerControl>();
        bc = GameObject.FindWithTag("Background").GetComponent<BgControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pc.Hp <= 0)
        {
            return;
        }
        if (transform.position.x < -4f)
        {
            Destroy(gameObject);
        }
        relativeSpeed = FireSpeed;
        if (pc.Horizontal < 0 && bc.Offset > 0)
        {
            relativeSpeed -= bc.MoveSpeed;
        }
        if (pc.Horizontal > 0)
        {
            relativeSpeed += bc.MoveSpeed;
        }
        transform.Translate(Vector3.left * relativeSpeed * Time.deltaTime);

    }
}
