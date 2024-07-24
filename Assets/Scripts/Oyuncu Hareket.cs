using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuHareket : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody saglamVucud;
    public float dikeyKuvvet;
    public float yatayKuvvet;
    public float ziplamaGucu;
    private bool yerdeMi=true;
    public AudioClip ziplama;
    public AudioSource ziplamaKaynagi;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("d"))
        {
            saglamVucud.AddForce(yatayKuvvet,0,0);
        }
        if(Input.GetKey("a"))
        {
            saglamVucud.AddForce(-yatayKuvvet,0,0);
        }
        if(Input.GetKey("w"))
        {
            saglamVucud.AddForce(0,0,dikeyKuvvet);
        }
        if(Input.GetKey("s"))
        {
            saglamVucud.AddForce(0,0,-dikeyKuvvet);
        }
        if(Input.GetKey(KeyCode.Space)&&yerdeMi==true)
        {
            ZiplamakIcin();
        }

    }
    void ZiplamakIcin()
    {
        yerdeMi=false;
        saglamVucud.AddForce(0,ziplamaGucu,0);
        ziplamaKaynagi.PlayOneShot(ziplama);
    }
    void OnCollisionEnter(Collision Bilgi)
    {
        if (Bilgi.gameObject.CompareTag("Ground"))
        {
            transform.position=new Vector3(0,1.3f,0);          
            yerdeMi=true;
        }
        if(Bilgi.gameObject.CompareTag("Obstacle"))
        {
            yerdeMi=true;
        }
        if(Bilgi.gameObject.CompareTag("Cylinder"))
        {
            yerdeMi=false;
        }
    }
}
