using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    private PlayerMovementScript playerMovementScript;
    private ShootingScript shootingScript;

    // Start is called before the first frame update
    void Start()
    {
        //Refrance to the player movemtn script
        playerMovementScript = GetComponent<PlayerMovementScript>();
        //Refrance to the shooting script
        shootingScript = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //Tracks the current time
        float currentTime = Time.time;
        //Detects if the horizontal arrow keys or a,d have been pressed
        float horizontalInput = Input.GetAxis("Horizontal");

        //If a,d or horizontal arrow keys have been pressed a function to move the ship will be called from the player movement script
        if (horizontalInput != 0.0f)
        {
            playerMovementScript.MoveShip(horizontalInput);
        }

        //If the left mouse button has been clicked it will call the shoot function in the shooting script
        if (Input.GetButton("Fire1"))
        {
            shootingScript.Shoot(currentTime);
        }
    }
}
