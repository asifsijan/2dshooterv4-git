using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King_attack : MonoBehaviour
{
    public int health;

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
