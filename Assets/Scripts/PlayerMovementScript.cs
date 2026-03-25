using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour 
{
    // SerializeField exposes this value to the Editor, but not to other Scripts!
    // It is "pseudo public"
    // HorizontalPlayerAcceleration indicates how fast we accelerate Horizontally
    [SerializeField]
    private float f_horPlayAccel = 5000f;

    private Rigidbody2D rigidBody;

    // Use this for initialization
    void Start() 
    {
        // Get OurRigidbodyComponent once at the start of the game and store a reference to it
        rigidBody = GetComponent<Rigidbody2D>(); 
    }

    public void MoveShip(float horizontalInput)
    {
        Vector2 ForceToAdd = Vector2.right * horizontalInput * f_horPlayAccel * Time.deltaTime;
        rigidBody.AddForce(ForceToAdd);
        //print(HorizontalInput);
    }
}
