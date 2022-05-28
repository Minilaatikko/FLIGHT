using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip jump, shoot;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        jump = Resources.Load<AudioClip>("jump");
        shoot = Resources.Load<AudioClip>("shoot");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "jump":
            audioSrc.PlayOneShot(jump);
            break;
            case "shoot":
            audioSrc.PlayOneShot(shoot);
            break;
        }
    }
}
