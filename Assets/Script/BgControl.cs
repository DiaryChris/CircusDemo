using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgControl : MonoBehaviour {

    private float offset = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Move(float dir)
    {
        if(dir == 1)
        {
            GetComponent<Renderer>().material.SetTextureOffset("MainTexture", new Vector2(offset += 0.4f * Time.deltaTime, 0));
        }
        else
        {
            GetComponent<Renderer>().material.SetTextureOffset("MainTexture", new Vector2(offset -= 0.4f * Time.deltaTime, 0));
        }
    }
}
