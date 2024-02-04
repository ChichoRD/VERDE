using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwordHitbox : MonoBehaviour
{
    public PlayerAnimatorController _animatorController;
    [SerializeField]
    private int damage = 1;
    [SerializeField]
    private float finishAnimTime = 0.25f; 
    private float currentAnimTime = 0; //habria que gestionarlo en el animator, o mandar una senal al animator
    [SerializeField]
    UnityEvent onDestroy = new UnityEvent();
    [SerializeField]LayerMask targetLayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<HealthSystem>() != null && targetLayer == (targetLayer | (1 << collision.gameObject.layer)))
        {
            print("hit");
            HealthSystem healthSystem = collision.gameObject.GetComponent<HealthSystem>();
            healthSystem.LoseHealth(damage, transform.position);
        }
    }
    private void Update()
    {
        currentAnimTime += Time.deltaTime;

        if (currentAnimTime > finishAnimTime)
        {
            Destroy(gameObject);
            PlayerAnimatorCall();
        }
    }
    private void OnDestroy()
    {
        onDestroy?.Invoke();
    }

    //llama al metodo de animator
    public void PlayerAnimatorCall()
    {
        _animatorController.onUsingItem(false, 0);
    }
}
