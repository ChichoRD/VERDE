using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceTowardsLookDirection : MonoBehaviour
{
    MovementController _movementController;
    private void Awake() {
        _movementController = GetComponent<MovementController>();
    }

    private void Update() {
        Vector2 lookDirection = _movementController.lookDirection;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle - 90);
    }
}
