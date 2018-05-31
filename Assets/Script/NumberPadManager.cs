using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberPadManager : MonoBehaviour
{
    public GameObject NumberPad;
    public GameObject WinPlatform;
    private float lastOffset;
    private float currentOffset;
    private int nextMetre;

    private BgControl bc;
    private GameObject clone;

    private float interval;

    // Use this for initialization
    void Start()
    {
        bc = GameObject.FindWithTag("Background").GetComponent<BgControl>();
        lastOffset = -1f;
        interval = 0.5f;
        nextMetre = 90;
    }

    // Update is called once per frame
    void Update()
    {
        currentOffset = bc.Offset;
        if (currentOffset > lastOffset + interval)
        {
            if(nextMetre < 0)
            {
                return;
            }
            clone = Instantiate(NumberPad, transform.position, Quaternion.identity);
            clone.transform.Find("Canvas").Find("Text").GetComponent<Text>().text = nextMetre.ToString();
            if (nextMetre == 0)
            {
                Instantiate(WinPlatform, transform.position + new Vector3(0, 1f, 0), Quaternion.identity);
            }
            nextMetre -= 10;
            lastOffset = currentOffset;
        }
    }
}
