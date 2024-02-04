using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollectable : MonoBehaviour, ICollectable
{
    [SerializeField] LinkStats stats;

    public void Collect(Collector collector)
    {
        if (stats.currentHealth < stats.maxHealth) {
            stats.currentHealth++;          
        }
        Destroy(gameObject);
    }
}

