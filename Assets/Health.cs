using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float health = 50f;

    public bool isAlive = true;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health < 0f)
        {

            Die();
            isAlive = false;
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
