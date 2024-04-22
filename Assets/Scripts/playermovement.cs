using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    SpriteRenderer spriteRenderer;
    public Animator anim;
    //public Animator myAnim;
    //public Animator Jumpanimation;
    //SpriteRenderer jumpanim;
    //Animator Jumpanim;
    public float stationaryTolerance = 0.005f;
    public float FallingThreshold = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        anim.Play("walking animation");
        anim.speed = 0;

    }

    // Check if player is standing still 
    public bool IsStationary
    {
        get
        {
            return myRigidbody.velocity.sqrMagnitude < stationaryTolerance * stationaryTolerance;
        }
    }

    bool isJumping()
    {
        if(myRigidbody.velocity.y > FallingThreshold)
        {
            return true;
        } else 
        {if (Input.GetKeyDown(KeyCode.Space) && myRigidbody.velocity.y == 0)
        {
            //Jumpanimation.Play("Jumpanimation");
            myRigidbody.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            //Jumpanim.SetTrigger("Jumpanimation");
            //anim.SetTrigger("jumptrigger");
            anim.Play("Jumpanimation");
            anim.speed = 1;
        } 
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(IsStationary)
        {
            anim.speed = 0;
        }

        
    }



void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput > 0)
        {
            if (true) 
            {
                //anim.SetTrigger("walktrigger");
                anim.Play("walking animation");
                anim.speed = 1;
            }
            myRigidbody.AddForce(new Vector2(7, 0));
            // Flip the sprite to face right
            spriteRenderer.flipX = false;
        }
        else if (horizontalInput < 0)
        {
            if (true)
            {
                //anim.SetTrigger("walktrigger");
                anim.Play("walking animation");
                anim.speed = 1;
            }
            myRigidbody.AddForce(new Vector2(-7, 0));
            // Flip the sprite to face left
            spriteRenderer.flipX = true;
        }

        if (horizontalInput > 0.01f || horizontalInput < -0.01f)
        {
            //anim.SetBool("isWalking", true);
            // transform.position += new Vector3(1, 0, 0); transform.position.x - 0.1;
            // GetComponent<Animation>().Play("walking");
        }
        else
        {
            //anim.SetBool("isWalking", false);
            //  GetComponent<Animation>().Play("idle");
        }
    }
}
