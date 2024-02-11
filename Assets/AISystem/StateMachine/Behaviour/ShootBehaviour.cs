using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehaviour : MonoBehaviour, IBehaviour
{
    ShootingComponent _shooter;
    MovementController _movementController;
    private void Awake() {
        _movementController = GetComponentInParent<MovementController>();
        _shooter = GetComponentInParent<ShootingComponent>();
    }

    public void ExecuteBehaviour()
    {
        _shooter.Shoot(_movementController.lookDirection);
    }
}
