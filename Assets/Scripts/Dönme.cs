using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donme : MonoBehaviour
{
    public Vector3 donmeHizi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(donmeHizi);
    }
}
