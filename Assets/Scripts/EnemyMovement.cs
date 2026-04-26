using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : EngineBase
{
    //This function is called in the AIMoveAndShoot script from that script the direction is given
    //and this function calls the accelerate function and moves the enmey in the specified direction
    public void MoveEnemy(Vector2 direction) 
    {
        Accelerate(direction);
    }
}
