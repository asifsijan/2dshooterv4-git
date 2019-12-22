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


    public Animator hurtAnim;
<<<<<<< Updated upstream
    //
    public float dashSpeed;

    public float dashTime;

    public GameObject dashEffect;
    public GameObject deathEffect;
=======


>>>>>>> Stashed changes


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
<<<<<<< Updated upstream
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dashEffect, transform.position, Quaternion.identity);
            StartCoroutine("DashMove");
        }
=======
>>>>>>> Stashed changes

    }

    //calls every physics frame 
    private void FixedUpdate() {
            rb.MovePosition(rb.position + moveAmount * Time.fixedDeltaTime); //fixedDeltatime=framerate independent 
    }


    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        hurtAnim.SetTrigger("hurt");
        if (health <= 0)
        {
<<<<<<< Updated upstream
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }

    IEnumerator DashMove()
    {
        speed = speed + dashSpeed;
        yield return new WaitForSeconds(dashTime);
        speed = speed - dashSpeed;
    }
=======
            Destroy(gameObject);
        }
    }


>>>>>>> Stashed changes



}
