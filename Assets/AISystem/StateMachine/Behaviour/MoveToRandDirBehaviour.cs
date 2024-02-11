using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToRandDirBehaviour : MonoBehaviour, IBehaviour
{
    TargetHandler targetHandler;
    MovementController movementController;
    Transform parentTransform;
    [SerializeField] Vector2 range;

    private void Awake() {
        movementController = GetComponentInParent<MovementController>();
        targetHandler = GetComponentInParent<TargetHandler>();
        parentTransform = movementController.transform;
    }

    public void ExecuteBehaviour()
    {
        Vector2 randomDirection = new Vector2(-targetHandler.transform.position.x, Random.Range(-range.y, range.y)).normalized;
        movementController.Rb.velocity = randomDirection.normalized * movementController.Speed;
    }

    //private void OnDrawGizmos()
    //{
       // Gizmos.color = Color.yellow;
       // Gizmos.DrawWireCube(transform.position, new Vector3(range.x , range.y , 0));
   // }
}
