using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour, IBehaviour
{
    MovementController movementController;

    private void Awake() {
        movementController = GetComponentInParent<MovementController>();
    }

    public void ExecuteBehaviour()
    {
        Vector2 direction = new Vector2(Mathf.PerlinNoise(Time.time, 0) - 0.5f, Mathf.PerlinNoise(0, Time.time) - 0.5f);
        direction.Normalize();

        //Ortogonally
        // if(Mathf.Abs(direction.x) > Mathf.Abs(direction.y)) direction.y = 0;
        // else direction.x = 0;

        direction.Normalize();

        movementController.Move(direction);
    }
}
