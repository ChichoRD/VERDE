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
        Vector2 randomPosition;
        Vector2 relativeDirection;
        Collider2D hit;
        int attempts = 0;

        do
        {
            randomPosition = new Vector2(Random.Range(-positionRange.x, positionRange.x), Random.Range(-positionRange.y, positionRange.y)) + (Vector2)targetHandler.target.position;
            relativeDirection = (randomPosition - (Vector2)targetHandler.target.position).normalized;
            randomPosition += new Vector2(relativeDirection.x * offset.x, relativeDirection.y * offset.y);
            hit = Physics2D.OverlapCircle(randomPosition, 0.1f);
            attempts++;
        }
        while(hit != null && attempts < 10);

        parentTransform.position = randomPosition;
    }

    private void OnValidate() {
        name = "TpRelativeToTargetBehaviour";
    }
}
