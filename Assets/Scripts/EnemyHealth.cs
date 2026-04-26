using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IHealth
{
    [SerializeField]
    protected int currentHealth;
    public int CurrentHealth { get { return currentHealth; } }

    [SerializeField]
    protected int maxHealth;
    public int MaxHealth { get { return maxHealth; } }

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void Heal(int healAmount)
    {
        //The enemys dont heal but the coding program said I
        //had an error if I didnt include this function
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        //UIManager.instance.UpdateEnemyHealthSlider((float)currentHealth / (float)maxHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("Die");
            currentHealth = 0;
            Die();
        }
    }
}
