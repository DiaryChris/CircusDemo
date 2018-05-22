using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour
{

    public GameObject FireBig;
    public GameObject FireDouble;
    public GameObject FireSmall;
    private GameObject lastFire;


    private PlayerControl pc;

    private float interval;
    private float rand;

    // Use this for initialization
    void Start()
    {
        pc = GameObject.FindWithTag("Player").GetComponent<PlayerControl>();
        rand = Random.Range(0, 1f);
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
            if (rand < 0.5)
            {
                lastFire = Instantiate(FireBig, transform.position, Quaternion.identity);
            }
            else if (rand < 0.8)
            {
                lastFire = Instantiate(FireDouble, transform.position, Quaternion.identity);
            }
            else
            {
                lastFire = Instantiate(FireSmall, transform.position + new Vector3(0, 0.26f, 0), Quaternion.identity);
            }
            interval = -3f + Random.Range(0, 4f);
            rand = Random.Range(0, 1f);
        }
    }
}
