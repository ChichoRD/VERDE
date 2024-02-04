using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{
    [SerializeField] LayerMask targertLayer;
    int damage = 1;

    private void OnTriggerEnter2D(Collider2D other) {
        if((targertLayer & 1 << other.gameObject.layer) != 0)
        {
            if(other.TryGetComponent(out HealthSystem healthSystem))
            {
                healthSystem.LoseHealth(damage);
                Destroy(this.gameObject);
            }
        }
    }
}
