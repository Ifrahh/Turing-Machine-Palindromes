using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource forward;
    public AudioSource backward;
    public AudioSource BG;
    public AudioSource accepted;
    public AudioSource r;

    public void f()
    {
        forward.Play();
    }
    public void b()
    {
        backward.Play();

    }
    public void bg()
    {
        BG.Play();
    }
}
