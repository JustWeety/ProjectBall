using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuyuTakipEt : MonoBehaviour
{
    public Transform oyuncu;
    public Vector3 fark;
    void Start ()
    {
    }
    void Update()
    {
        transform.position = (oyuncu.position-fark);
    }
}
