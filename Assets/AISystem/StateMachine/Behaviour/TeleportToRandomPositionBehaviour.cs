using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToRandomPositionBehaviour : MonoBehaviour, IBehaviour
{
    [SerializeField] Vector2 positionRange;
    MovementController movementController;
    Transform parentTransform;
    Vector2 initialPosition;

    private void Awake() {
        movementController = GetComponentInParent<MovementController>();
        parentTransform = movementController.transform;
        initialPosition = parentTransform.position;
    }

    public void ExecuteBehaviour()
    {
        Vector2 randomPosition = new Vector2(Random.Range(-positionRange.x, positionRange.x), Random.Range(-positionRange.y, positionRange.y)) + initialPosition;
        parentTransform.position = randomPosition;
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(positionRange.x * 2, positionRange.y * 2, 0));
    }
}
