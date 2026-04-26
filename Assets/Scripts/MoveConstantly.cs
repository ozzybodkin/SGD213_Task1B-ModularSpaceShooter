using UnityEngine;
using System.Collections;

/// <summary>
/// MoveConstantly gives an object the ability to continuously move based on the
/// specified direction
/// </summary>
public class MoveConstantly : MonoBehaviour
{
    //This varible stores the acceleration of the object
    [SerializeField]
    private float acceleration = 100f;

    //This varible stores the initial velocity of the object
    [SerializeField]
    private float initialVelocity = 10f;

    [SerializeField]
    // our direction to move in
    private Vector2 direction = new Vector2(0, 1);

    //Sets the direction varible to a Vector if its not already one
    public Vector2 Direction 
    {
        get 
        {
            return direction;
        }
        set {
            if (value.magnitude == 1) 
            {
                direction = value;
            } 
            else 
            {
                direction = value.normalized;
            }
        }
    }

    // local references to the rigidbody component
    private Rigidbody2D ourRigidbody;

    void Start()
    {
        //Finds the components and sets them to the local refrances
        ourRigidbody = GetComponent<Rigidbody2D>();

        //Sets the velocity of the object
        ourRigidbody.velocity = direction * initialVelocity;
    }

    void Update()
    {
        // calculate our force to add, based on our provided direction, acceleration and delta time
        Vector2 forceToAdd = direction * acceleration * Time.deltaTime;
        // add our forceToAdd to ourRigidbody
        ourRigidbody.AddForce(forceToAdd);
    }
}
