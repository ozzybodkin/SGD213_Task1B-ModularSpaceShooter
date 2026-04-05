using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour {

    MovementController movementController;

    private bool direction = true;

    // Use this for initialization
    void Start()
    {
        movementController = GetComponent<MovementController>();

        movementController.SetInitialVelocity(direction);
    }

    // Update is called once per frame
    void Update()
    {
        movementController.MoveForward(direction);
    }
}
