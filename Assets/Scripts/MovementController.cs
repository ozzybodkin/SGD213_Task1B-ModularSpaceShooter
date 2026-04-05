using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    //The rate at which the object will increase in speed
    public float acceleration;

    //Initial speed of the object
    public float initialVelocity;

    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        //Refrance to the objects rigidbody componemt
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    //Sets the intial direction and velocity of the object once called
    public void SetInitialVelocity(bool direction)
    {
        if (direction == true)
        {
            ourRigidbody.velocity = Vector2.up * initialVelocity;
        }
        else if (direction == false)
        {
            ourRigidbody.velocity = Vector2.down * initialVelocity;
        }
    }

    //Adds accelation in the direction the object was moving
    public void MoveForward(bool direction)
    {
        if (direction == true)
        {
            Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;

            ourRigidbody.AddForce(ForceToAdd);
        }
        else if(direction == false)
        {
            Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;

            ourRigidbody.AddForce(ForceToAdd);
        }
    }
}
