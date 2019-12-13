using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    
    public float speed;
    private Rigidbody2D rb; //contains unitys physics

    private Animator anim; 
  
    private Vector2 moveAmount;
  // determines game's start 
    private void Start() {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    //called every frame
    private void Update(){
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveAmount = moveInput.normalized * speed;

        if (moveInput != Vector2.zero){
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

    }

    //calls every physics frame 
    private void FixedUpdate() {
            rb.MovePosition(rb.position + moveAmount * Time.fixedDeltaTime); //fixedDeltatime=framerate independent 
    }








}
