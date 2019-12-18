using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palinaudio : MonoBehaviour
{
    public AudioSource frward;
    public AudioSource bckward;
    public AudioSource bg1;
    void start()
    {
        bg1.Play();
    }
    public void ff()
    {
        frward.Play();
    }
    public void bb()
    {
        bckward.Play();

    }
}
