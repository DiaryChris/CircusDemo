using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePotManager : MonoBehaviour {

    public GameObject FirePot;
    private float lastOffset;
    private float currentOffset;

    private BgControl bc;

    private float interval;

    // Use this for initialization
    void Start () {
        bc = GameObject.FindWithTag("Background").GetComponent<BgControl>();
        lastOffset = 0f;
        interval = 0f;
    }

    // Update is called once per frame
    void Update () {

        currentOffset = bc.Offset;
        if (currentOffset > lastOffset + interval)
        {
            Instantiate(FirePot, transform.position, Quaternion.identity);
            lastOffset = currentOffset;
            interval = 0.5f + Random.Range(0f, 1f);
        }
    }
}
