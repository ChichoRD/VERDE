using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnter : MonoBehaviour
{
    [SerializeField] LayerMask targertLayer;
    [SerializeField]int damage = 1;
    [SerializeField]UnityEvent onHit = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D other) {
        if((targertLayer & 1 << other.gameObject.layer) != 0)
        {
            onHit?.Invoke();
            if(other.TryGetComponent(out HealthSystem healthSystem))
            {
                healthSystem.LoseHealth(damage, transform.position);
            }
        }
    }
}
