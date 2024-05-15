using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int health;
    public UnityEvent onDeath;
    public virtual void Damage(int damage)
    {
        health -= damage;
        CheckForDeath();
    }

    public void CheckForDeath()
    {
        if (health <= 0)
        {
            onDeath.Invoke();
            Destroy(gameObject);
        }
    }
}
