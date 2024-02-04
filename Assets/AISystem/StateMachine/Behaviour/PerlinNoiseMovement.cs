using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoiseMovement : MonoBehaviour, IBehaviour
{
    MovementController _movementController;
    float timeVariation = 1;
    private void Awake() {
        _movementController = GetComponentInParent<MovementController>();
        timeVariation = Random.Range(0.5f, 2f);
    }

    public void ExecuteBehaviour()
    {
        float x = Mathf.PerlinNoise(Time.time * timeVariation, 0) * 2 - 1;
        float y = Mathf.PerlinNoise(0, Time.time * timeVariation) * 2 - 1;

        if(x > y) y = 0;
        else x = 0;

        Vector2 direction = new Vector2(x, y).normalized;
        _movementController.Move(direction);
    }
}
