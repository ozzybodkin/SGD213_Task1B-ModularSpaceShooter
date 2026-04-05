using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float acceleration;

    public float initialVelocity;

    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

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
