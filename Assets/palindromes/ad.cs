using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ad : MonoBehaviour
{
    public AudioSource es;
        public AudioSource bs;
    public AudioSource bh;
    public AudioSource accepted;
    public AudioSource r;
   
    // Start is called before the first frame update
    void start()
    {
        bh.Play();
    }
    public void ff()
    {
        es.Play();
    }
    public void bb()
    {
       bs.Play();

    }
}
