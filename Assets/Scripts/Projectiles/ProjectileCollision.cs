using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    #region parameters

    [SerializeField]
    protected int damage = 1;

    #endregion

    #region references

    protected ProjectileMovement movement;

    #endregion

    #region methods

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthSystem entityHealth = collision.GetComponent<HealthSystem>();

        if (entityHealth != null)
        {
            entityHealth.LoseHealth(damage, Vector2.zero);
        }
        else if(collision.gameObject.layer != LayerMask.NameToLayer("UI")) return;     

        DestructionProcess();
    }

    public void DestroyGameobject()
    {
        Destroy(gameObject);
    }

    protected void DestructionProcess()
    {
        movement.SetDirection(Vector2.zero);

        Animator anim = GetComponent<Animator>();

        if (anim != null && AnimHasParameter(anim, "Destroyed"))
        {
            anim.SetBool("Destroyed", true);
        }
        else
        {
            DestroyGameobject();
        }
    }

    private bool AnimHasParameter( Animator animator, string paramName)
    {
        foreach (AnimatorControllerParameter param in animator.parameters)
        {
            if (param.name == paramName)
                return true;
        }
        return false;
    }

    #endregion

    void Start()
    {
        movement = GetComponent<ProjectileMovement>();
    }

    void Update()
    {
        
    }
}
