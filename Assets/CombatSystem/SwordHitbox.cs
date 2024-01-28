using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    [SerializeField]
    public Sword referencedSword;
    public Collider2D playerCollider;
    [SerializeField]
    private int damage = 1;
    [SerializeField]
    private float finishAnimTime = 0.25f; 
    private float currentAnimTime = 0; //habria que gestionarlo en el animator, o mandar una senal al animator

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<HealthSystem>() != null && collision.gameObject.GetComponent <Collider2D>() == playerCollider)
        {
            HealthSystem healthSystem = collision.gameObject.GetComponent<HealthSystem>();
            healthSystem.LoseHealth(damage);
        }
    }
    private void Update()
    {
        currentAnimTime += Time.deltaTime;

        if (currentAnimTime > finishAnimTime)
        {
            Destroy(gameObject);
            referencedSword.attacking = false;
        }
    }
}
