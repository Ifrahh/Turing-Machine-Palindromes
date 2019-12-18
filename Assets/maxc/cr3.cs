using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cr3 : MonoBehaviour
{

    public float x = 3f;
    public float y = 3f;
    public float z = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x, y, z);
    }
}
