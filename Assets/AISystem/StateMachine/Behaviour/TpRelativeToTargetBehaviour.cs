using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpRelativeToTargetBehaviour : MonoBehaviour, IBehaviour
{
    TargetHandler targetHandler;
    MovementController movementController;
    Transform parentTransform;

    [SerializeField] Vector2 positionRange;
    [SerializeField] Vector2 offset;

    private void Awake() {
        targetHandler = GetComponentInParent<TargetHandler>();
        movementController = GetComponentInParent<MovementController>();
        parentTransform = movementController.transform;
    }

    public void ExecuteBehaviour()
    {
        Vector2 randomPosition = 
        new Vector2(Random.Range(-positionRange.x, positionRange.x), Random.Range(-positionRange.y, positionRange.y)) + (Vector2)targetHandler.target.position;
        Vector2 relativeDirection = (randomPosition - (Vector2)targetHandler.target.position).normalized;
        randomPosition += new Vector2(relativeDirection.x * offset.x, relativeDirection.y * offset.y);

        parentTransform.position = randomPosition;
    }

    private void OnValidate() {
        name = "TpRelativeToTargetBehaviour";
    }
}
