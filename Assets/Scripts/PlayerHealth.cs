using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealth
{
    //Varible to Track the players current health
    [SerializeField]
    protected int currentHealth;
    public int CurrentHealth { get { return currentHealth; } }

    //Varible to Track the players max health
    [SerializeField]
    protected int maxHealth;
    public int MaxHealth { get { return maxHealth; } }

    void Start()
    {
        //Sets the current health of the players to full when the game starts
        currentHealth = maxHealth;
    }

    // <summary>
    /// Heal restores the players health
    /// </summary>
    public void Heal(int healingAmount)
    {
        currentHealth += healingAmount;

        UIManager.instance.UpdatePlayerHealthSlider(currentHealth);

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    //A function that runs when the player takes damage it tracks the damage
    //and runs the Die function if the players health reaches 0
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        UIManager.instance.UpdatePlayerHealthSlider(currentHealth);

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    /// <summary>
    /// Handles all functionality related to when health reaches or goes below zero, should perform all necessary cleanup.
    /// </summary>
    public void Die()
    {
        // would be good to do some death animation here maybe
        // remove this object from the game
        Destroy(gameObject);
    }
}
