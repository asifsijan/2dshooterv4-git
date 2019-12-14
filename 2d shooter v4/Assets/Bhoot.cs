using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bhoot : Enemy
{




    public float stopDistance;



    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (Vector2.Distance(transform.position, player.position) > stopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
        }
    }





}
