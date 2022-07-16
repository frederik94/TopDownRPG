using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBase : MonoBehaviour
{
    public PlayerProgress playerStats;
    public BaseStats baseStats;

    public float movementSpeed = 50f;

    public void TakeDamage(float damage)
    {
        baseStats.currentHealth -= damage;

        if (baseStats.currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
