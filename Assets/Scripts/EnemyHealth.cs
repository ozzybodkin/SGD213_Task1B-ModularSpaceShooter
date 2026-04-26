using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IHealth
{
    //Varible to Track the enemys current health
    [SerializeField]
    protected int currentHealth;
    public int CurrentHealth { get { return currentHealth; } }

    //Varible to Track the enemys max health
    [SerializeField]
    protected int maxHealth;
    public int MaxHealth { get { return maxHealth; } }

    void Start()
    {
        //Sets the current health of the enemy to full when they are spawned
        currentHealth = maxHealth;
    }

    //Destroys the enemy game object
    public void Die()
    {
        Destroy(gameObject);
    }

    public void Heal(int healAmount)
    {
        //The enemys dont heal but the coding program said I
        //had an error if I didnt include this function
    }

    //A function that runs when the enemy takes damage it tracks the damage
    //and runs the Die function if the enemys health reaches 0
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Debug.Log("Die");
            currentHealth = 0;
            Die();
        }
    }
}
