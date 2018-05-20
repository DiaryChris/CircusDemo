using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgControl : MonoBehaviour
{

    public float Offset = 0;
    public float MoveSpeed = 1.8f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //背景移动函数
    public bool Move(float dir)
    {
        if (dir == 0)
        {
            return false;
        }
        if (dir > 0)
        {
            Offset += MoveSpeed * 0.15f * Time.deltaTime;
        }
        if (dir < 0)
        {
            if (Offset == 0)
            {
                return false;
            }
            Offset -= MoveSpeed * 0.15f * Time.deltaTime;
            if (Offset < 0)
            {
                Offset = 0;
            }
        }
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Offset, 0);
        return true;
    }
}
