using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float verticalForce;
    public float horizontalForce;
    public float jumpForce;
    private bool isOnGround=true;
    public AudioClip jumpSound;
    public AudioSource jumpSoundSource;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("d"))
        {
            rb.AddForce(horizontalForce,0,0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-horizontalForce,0,0);
        }
        if(Input.GetKey("w"))
        {
            rb.AddForce(0,0,verticalForce);
        }
        if(Input.GetKey("s"))
        {
            rb.AddForce(0,0,-verticalForce);
        }
        if(Input.GetKey(KeyCode.Space)&&isOnGround==true)
        {
            toJump();
        }

    }
    void toJump()
    {
        isOnGround=false;
        rb.AddForce(0,jumpForce,0);
        jumpSoundSource.PlayOneShot(jumpSound);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Ground"))
        {
            transform.position=new Vector3(0,1.3f,0);          
            isOnGround=true;
        }
        if(collisionInfo.gameObject.CompareTag("Obstacle"))
        {
            isOnGround=true;
        }
    }
}
