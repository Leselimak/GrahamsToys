using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource _soundSource;
    private AudioClip _runningSound;
    private AudioClip _swordSound;
    private AudioClip _gunSound;

    // Start is called before the first frame update
    void Start()
    {
        _soundSource = GetComponent<AudioSource>();
        _runningSound = Resources.Load("Dress-Shoes-on-Metal-Stairs--Faster--1-www.fesliyanstudios.com") as AudioClip;
        _swordSound = Resources.Load("Drawing-A-Sword-www.fesliyanstudios.com") as AudioClip;
        _gunSound = Resources.Load("308-Bolt-Action-Rifle-Single-Close-Gunshot-A-www.fesliyanstudios.com") as AudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGunSound()
    {
        _soundSource.PlayOneShot(_gunSound);
    }

    public void PlaySwordSound()
    {
        _soundSource.PlayOneShot(_swordSound);
    }

    public void PlayRunSound()
    {
        _soundSource.PlayOneShot(_runningSound);
        print("running");
    }
}
