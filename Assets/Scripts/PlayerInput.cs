using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// PlayerInput handles all of the player specific input behaviour, and passes the input information
/// to the appropriate scripts.
/// </summary>
public class PlayerInput : MonoBehaviour
{
    // local references to the PlayerMovement Script and the WeaponBase script
    private PlayerMovement playerMovement;

    private WeaponBase weapon;
    public WeaponBase Weapon
    {
        get
        {
            return weapon;
        }

        set
        {
            weapon = value;
        }
    }

    //Finds the components and sets them to the local refrances
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        weapon = GetComponent<WeaponBase>();
    }

    void Update()
    {
        // checks if the A,D, Left Arrow or Right Arrow keys have been pressed
        float horizontalInput = Input.GetAxis("Horizontal");
        // if movement input is not zero
        if (horizontalInput != 0.0f)
        {
            // ensure our playerMovementScript is active
            if (playerMovement != null)
            {
                // pass our movement input to our playerMovementScript
                playerMovement.MovePlayer(horizontalInput * Vector2.right);
            }
        }

        // if we press the Fire1 button
        if (Input.GetButton("Fire1"))
        {
            // if our shootingScript is active
            if (weapon != null)
            {
                // tell shootingScript to shoot
                weapon.Shoot();
            }
        }
    }

    //Changes the type of weapon that the player currently has
    public void SwapWeapon(WeaponType weaponType)
    {
        // makes a weapon depending on the desired weapon type
        WeaponBase newWeapon = null;
        switch (weaponType)
        {
            case WeaponType.machineGun:
                newWeapon = gameObject.AddComponent<WeaponMachineGun>();
                break;
            case WeaponType.tripleShot:
                newWeapon = gameObject.AddComponent<WeaponTripleShot>();
                break;
        }

        // update the data of our newWeapon with that of our current weapon
        newWeapon.UpdateWeaponControls(weapon);
        // remove the old weapon
        Destroy(weapon);
        // set our current weapon to be the newWeapon
        weapon = newWeapon;
    }
}
