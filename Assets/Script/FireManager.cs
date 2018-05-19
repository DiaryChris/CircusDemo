using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour
{

    public GameObject FireBig;
    private GameObject lastFire;


    private PlayerControl pc;
    private BgControl bc;

    private float interval;

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
        //如果没有火圈或上一个火圈触发间隔
        if (!lastFire || lastFire.transform.position.x < interval)
        {
            lastFire = Instantiate(FireBig, transform.position, Quaternion.identity);
            interval = -3f + Random.Range(0, 4f);
        }
    }
}
