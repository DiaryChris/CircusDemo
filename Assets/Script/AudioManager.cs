using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public static AudioManager Instance;

    private AudioSource player;

    public AudioClip Jump;
    public AudioClip Crash;
    public AudioClip Die;
    public AudioClip Begin;

    // Use this for initialization
    void Start () {
        Instance = this;
        player = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        player.PlayOneShot(Jump);
    }

    public void PlayCrash()
    {
        player.Stop();
        player.PlayOneShot(Crash);
        Invoke("PlayDie", 1f);
    }

    public void PlayDie()
    {
        player.PlayOneShot(Die);
    }

    public void PlayBegin()
    {
        player.PlayOneShot(Begin);
    }
}
