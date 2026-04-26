using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EngineBase : MonoBehaviour
{
    // acceleration indicates how fast the enemy accelerates
    [SerializeField]
    protected float acceleration = 5000f;

    // local references
    protected Rigidbody2D ourRigidbody;

    void Start()
    {
        //Gets a rafrence to the objects Rigidbody component
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    //This function moves in object in a direction that is inputed into it when it's called
    public void Accelerate(Vector2 direction)
    {
        //calculate our force to add
        Vector2 forceToAdd = direction * acceleration * Time.deltaTime;
        // apply forceToAdd to ourRigidbody
        ourRigidbody.AddForce(forceToAdd);
    }
}
