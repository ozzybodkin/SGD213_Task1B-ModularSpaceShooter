using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Swaps the players weapon
/// </summary>
public class Pickup : MonoBehaviour
{
    //This varible keeps track of the players current weapon type
    [SerializeField]
    public WeaponType weaponType;

    //This fucntion is called when the pick up object collides with something
    void OnTriggerEnter2D(Collider2D col)
    {
        //If the object that was collided with has the player tag the HandlePlayerPickup function is called
        if (col.gameObject.tag == "Player")
        {
            GameObject player = col.gameObject;
            HandlePlayerPickup(player);
        }
    }

    //Swaps the players weapon
    private void HandlePlayerPickup(GameObject player)
    {
        // get the playerInput from the player
        PlayerInput playerInput = player.GetComponent<PlayerInput>();
        // handle a case where the player doesnt have a PlayerInput
        if (playerInput == null) {
            Debug.LogError("Player doesn't have a PlayerInput component.");
            return;
        } else {
            // tell the playerInput to SwapWeapon based on our weaponType
            playerInput.SwapWeapon(weaponType);
        }
    }

}

public enum WeaponType { machineGun, tripleShot }
