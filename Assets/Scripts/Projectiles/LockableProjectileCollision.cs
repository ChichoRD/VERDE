using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockableProjectileCollision : ProjectileCollision
{
    #region properties

    private bool hasBeenBlocked = false;

    private float timeAfterBounce = 0.4f;

    #endregion

    #region methods

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthSystem entityHealth = collision.GetComponent<HealthSystem>();

        PlayerController playerController = collision.GetComponent<PlayerController>();

        if (entityHealth != null && playerController != null)
        {
            if(playerController.lookDirection != -movement.DirectionVector) // Also check if player isn't blocking if projectile collides with it
            {
                entityHealth.LoseHealth(damage, Vector2.zero);

                DestructionProcess();

                return;
            }

            hasBeenBlocked = true;

            movement.faceMovementDirection = false;

            if (movement.DirectionVector.y < 0.01f) // Movement is horizontal
            {
                movement.SetDirection(-movement.DirectionVector + Vector2.up * 0.5f);
            }
            else
            {
                movement.SetDirection(-movement.DirectionVector + Vector2.right * 0.5f);
            }
        }
        else if(collision.gameObject.layer == LayerMask.NameToLayer("UI"))
        {
            DestructionProcess();
        }
    }

    #endregion

    void Start()
    {
        movement = GetComponent<ProjectileMovement>();
    }

    void Update()
    {
        if (hasBeenBlocked == true)
        {
            timeAfterBounce -= Time.deltaTime;

            if(timeAfterBounce <= 0) DestroyGameobject();
        }
    }
}
