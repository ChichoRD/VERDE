using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToRandDirBehaviour : MonoBehaviour, IBehaviour
{
    MovementController movementController;
    [SerializeField] Vector2 range;

    private void Awake() {
        movementController = GetComponentInParent<MovementController>();
    }

    public void ExecuteBehaviour()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-range.x, range.x), Random.Range(-range.y, range.y)).normalized;
        movementController.Rb.velocity = randomDirection.normalized * movementController.Speed;
    }
}
