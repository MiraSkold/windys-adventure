using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class newplayermovement : MonoBehaviour
{
    float horizontalInput;
    float moveSpeed = 5f;
    bool isFacingRight = false;
   
    

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        FlipSprite();
        bool isJumping = Input.GetKeyDown(KeyCode.Space);
        animator.SetBool("isJumping", isJumping);

        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            rb.AddForce(new Vector2(0, 7), ForceMode2D.Impulse);
            animator.SetBool("isJumping", true);
        }

       
    }
    
    private void FixedUpdate() 
    {
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        bool isWalking = Math.Abs(rb.velocity.x) > 0;
        bool isAttacking = Input.GetMouseButtonDown(0);

        animator.SetBool ("isWalking", isWalking);
        animator.SetBool ("isIdle", ! isWalking && !isAttacking);
        animator.SetBool ("isAttacking", isAttacking);

        if (rb.velocity.y == 0) {
            if (horizontalInput > .1f || horizontalInput < -.1f)
            {
                animator.SetBool("isWalking", true);

            }
            else
            {
                animator.SetBool("isIdle", true);
            }

            
        }
        if (Input.GetMouseButtonDown(0))
        {
           
            animator.SetBool("isAttacking", true);
    
               

           
        }

    }
    void FlipSprite()
    {
        if (isFacingRight && horizontalInput < 0f || !isFacingRight && horizontalInput > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 Is = transform.localScale;
            Is.x *= -1f;
            transform.localScale = Is;
        }
    }
    
}
