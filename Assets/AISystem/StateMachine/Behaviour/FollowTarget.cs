using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour, IBehaviour
{
    TargetHandler targetHandler;
    MovementController movementController;
    [SerializeField] int multiplier = 1;

    private void Awake()
    { 
        targetHandler = GetComponentInParent<TargetHandler>();
        movementController = GetComponentInParent<MovementController>();
    }

    public void ExecuteBehaviour() => movementController.MoveTowards(targetHandler.target.position, multiplier);

    private void OnValidate() {
        if(multiplier >= 0)
            gameObject.name = $"Follow Target x{multiplier}";
        else
            gameObject.name = $"Move Away x{multiplier}";
    }
}
