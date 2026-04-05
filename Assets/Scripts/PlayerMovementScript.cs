using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour 
{
    // SerializeField exposes this value to the Editor, but not to other Scripts!
    // playerAcceleration indicates how fast we accelerate Horizontally
    [SerializeField] private float playerAccelarate = 5000f;

    private Rigidbody2D rigidBody;

    // Use this for initialization
    void Start() 
    {
        // Get OurRigidbodyComponent once at the start of the game and store a reference to it
        rigidBody = GetComponent<Rigidbody2D>(); 
    }

    //Moves the player left or right depending on which button was pressed
    public void MoveShip(float horizontalInput)
    {
        Vector2 ForceToAdd = Vector2.right * horizontalInput * playerAccelarate * Time.deltaTime;
        rigidBody.AddForce(ForceToAdd);
        //print(HorizontalInput);
    }
}
