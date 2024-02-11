using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamageToTarget : MonoBehaviour
{
    [SerializeField] LayerMask targertLayer;
    [SerializeField] int damage = 1;
    [SerializeField] float radius = 1.5f;
    float timeToDamage = 0;
    private void Update() {
        timeToDamage -= Time.deltaTime;
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius, targertLayer);
        if(hit && timeToDamage <= 0)
        {
            timeToDamage = 0.5f;
            if(hit.TryGetComponent(out HealthSystem healthSystem))
            {
                healthSystem.LoseHealth(damage, transform.position);
            }
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
