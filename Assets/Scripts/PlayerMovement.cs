using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

public class PlayerMovement : EngineBase
{
    //This function is called from PlayerInput when A or D is pressed
    // This function will move the player in a horizontal direction depending on if it was A or D that was pressed
    public void MovePlayer(Vector2 direction)
    {
        // a horizontalInput of 0 has no effect, as we want our ship to drift
        if (direction.magnitude != 0)
        {
            Accelerate(direction);
        }
    }
}
