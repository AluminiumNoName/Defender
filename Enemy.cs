using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //variables for health, speed and animator (for later)
    public int health;
    public float speed = 1;

    public Animator animator;

    public void TakeDamage()
    { // take damage means Enemy's health goes -1 and if it's 0 and less - Enemy dead
        health -= 1;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


    private void Update()
    {
        // enemy's x
        float enemyPosx = transform.position.x;
        // unique variable for unique field's x
        float cornPosX = Corn.singleton.transform.position.x;

        //when enemy's x more than corn's x they move (like the arrow kinda)
        if (enemyPosx > cornPosX)
        {
         transform.position += speed * transform.right * Time.deltaTime * (-1);
         
        }
        else
        {
         
        }
    }

}
