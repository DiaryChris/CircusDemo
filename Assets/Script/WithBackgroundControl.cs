using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithBackgroundControl : MonoBehaviour
{
    private GameObject bg;
    private BgControl bc;
    private PlayerControl pc;

    private float initOffset;
    private float currentOffset;
    private float initX;
    private float initY;
    private float translation;

    // Use this for initialization
    void Start()
    {
        bg = GameObject.FindWithTag("Background");
        pc = GameObject.FindWithTag("Player").GetComponent<PlayerControl>();
        bc = bg.GetComponent<BgControl>();
        initOffset = bc.Offset;
        initX = transform.position.x;
        initY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (pc.Hp <= 0)
        {
            return;
        }
        currentOffset = bc.Offset;
        translation = (currentOffset - initOffset) * 8;
        Move();
    }

    public bool Move()
    {
        transform.position = new Vector3(0, initY, 0) + new Vector3(1, 0, 0) * (initX - translation);
        return true;
    }
}
