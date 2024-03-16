using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private float JumpForce = 10f;
    [SerializeField] private Transform ghost;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform charPos;
    [SerializeField] private float groundDistance = 0.25f;
    [SerializeField] private float JumpTime = 0.3f;
    [SerializeField] private float bendHeight = 4f;

    private bool isGrounded = false;
    private bool isJumping = false;
    private float JumpTimer;

    private void Update(){
        isGrounded = Physics2D.OverlapCircle(charPos.position, groundDistance, groundLayer);
        if (isGrounded && Input.GetKeyDown("space")){
            isJumping = true;
            rb2d.velocity = Vector2.up * JumpForce;
        }
        if (isJumping && Input.GetKey("space")){
            if (JumpTimer < JumpTime){
                rb2d.velocity = Vector2.up * JumpForce;
                JumpTimer += Time.deltaTime;
            }else{
                isJumping = false;
            }
            }
            if (Input.GetKeyUp("space")){
                isJumping = false;
                JumpTimer = 0;
            }
        }
        }
    
        


