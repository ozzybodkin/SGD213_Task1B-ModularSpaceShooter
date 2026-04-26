using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : DetectCollisionBase
{
    //Tracks how much damage will be dealt
    [SerializeField]
    private int damageToDeal;

    //Tracks how much will be healed
    [SerializeField]
    private int healAmount;

    //Deals damage to whatever the game object has hit unless the game object
    // is a heal pick up colliding with the player in that case the player will be healed
    protected override void ProcessCollision(GameObject other)
    {
        base.ProcessCollision(other);
        if (other.GetComponent<IHealth>() != null) 
        {
            other.GetComponent<IHealth>().TakeDamage(damageToDeal);

            if (gameObject.tag == "HealPickUp")
            {
                other.GetComponent<IHealth>().Heal(healAmount);
            }
        } 
        else 
        {
            Debug.Log(other.name + " does not have an IHealth component");
        }

        Destroy(gameObject);
    }
}
