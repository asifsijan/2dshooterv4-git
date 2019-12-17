using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelleEnemy : Enemy
{
    public float stopDistance;

    private float AttackTime;

    private void Update()
    {
        if (player != null)
        {
            if (Vector2.Distance(transform.position, player.position) > stopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
            else
            {
                if (Time.time >= AttackTime)
                {
                    StartCoroutine(Attack());
                    AttackTime = Time.time + timeBetweenAttacks;
                }
            }
        }
    }

    IEnumerator Attack()
    {
        player.GetComponent<Player>().TakeDamage(damage);

    }
}
  