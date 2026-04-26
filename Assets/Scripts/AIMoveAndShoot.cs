using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMoveAndShoot : MonoBehaviour 
{

    // The direction the enemy will move
    private Vector2 movementDirection;

    // Refrances to the EnemyMovement script and the WeaponBase script
    private EnemyMovement enemyMovement;
    private WeaponBase weapon;

    void Start() 
    {
        // Tells the varibels where the scripts they are should be refrancing are
        enemyMovement = GetComponent<EnemyMovement>();
        weapon = GetComponent<WeaponBase>();

        // get a random direction between South-East and South-West
        float x = Random.Range(-0.5f, 0.5f);
        float y = -0.5f;
        movementDirection = new Vector2(x, y).normalized; // ensure it is normalised
    }

    // Update is called once per frame
    void Update () 
    {
        // move our enemy if we have a EnemyMovement component attached
        if (enemyMovement != null) {
            enemyMovement.MoveEnemy(movementDirection);
        }

        // shoot if we have a WeaponBase component attached
        if (weapon != null) {
            weapon.Shoot();
        }
    }
}
