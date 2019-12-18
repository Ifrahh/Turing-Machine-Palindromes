using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio2 : MonoBehaviour
{
    public AudioSource forward;
    public AudioSource backward;
    public AudioSource background;
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
        background.Play();

    }
}
