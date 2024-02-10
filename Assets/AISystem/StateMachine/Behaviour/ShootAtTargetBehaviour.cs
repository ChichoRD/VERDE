using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtTargetBehaviour : MonoBehaviour, IBehaviour
{

    Shooter _shooter;
    TargetHandler _targetHandler;
    public void ExecuteBehaviour()
    {
        Vector2 targetPos = _targetHandler.target.position-transform.position;
        _shooter.Shoot(targetPos);
    }
    void Start() 
    { 
        _targetHandler = GetComponentInParent<TargetHandler>();
        _shooter = GetComponentInParent<Shooter>();
    }
}
