using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("AUDIO SOURCES")]
    [SerializeField] AudioSource bg;
    [SerializeField] AudioSource sfx;
    [Header("AUDIO CLIPS")]
    public AudioClip background;
    public AudioClip flap;
    public AudioClip coin;
    public AudioClip death;

    public void Start()
    {
        bg.clip = background;
        bg.Play();
    }

    public void playSFX(AudioClip clip,float vol)
    {
        sfx.PlayOneShot(clip,vol);
    }


}
