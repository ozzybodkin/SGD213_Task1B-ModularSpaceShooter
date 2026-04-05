using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveforward : MonoBehaviour
{
    MovementController movementController;

    //Sets the movement direction of the object
    public bool direction;

    // Use this for initialization
    void Start()
    {
        //Refrance to a differnt script with the movement code
        movementController = GetComponent<MovementController>();

        //Calls a function that sets the objects intial velocity and direction
        movementController.SetInitialVelocity(direction);
    }

    // Update is called once per frame
    void Update()
    {
        //Calls a function that adds accelration to the object
        movementController.MoveForward(direction);
    }
}
