using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : DetectCollisionBase
{
    [SerializeField]
    private int damageToDeal;

    [SerializeField]
    private int healAmount;

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
