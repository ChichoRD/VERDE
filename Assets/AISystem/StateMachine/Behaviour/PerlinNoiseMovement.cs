using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoiseMovement : MonoBehaviour, IBehaviour
{
    MovementController _movementController;
    private void Awake() {
        _movementController = GetComponentInParent<MovementController>();
    }

    public void ExecuteBehaviour()
    {
        float x = Mathf.PerlinNoise(Time.time, 0) * 2 - 1;
        float y = Mathf.PerlinNoise(0, Time.time) * 2 - 1;

        if(x > y) y = 0;
        else x = 0;

        Vector2 direction = new Vector2(x, y).normalized;
        _movementController.Move(direction);
    }
}
