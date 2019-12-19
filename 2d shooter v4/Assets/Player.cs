using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb; //contains unitys physics

    private Animator anim;
    public float health;
    public Slider healthBar;

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
        healthBar.value = health;

    }

    //calls every physics frame 
    private void FixedUpdate() {
            rb.MovePosition(rb.position + moveAmount * Time.fixedDeltaTime); //fixedDeltatime=framerate independent 
    }


    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }





}
