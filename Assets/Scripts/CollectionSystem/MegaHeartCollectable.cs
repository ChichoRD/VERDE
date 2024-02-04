using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaHeartCollectable : MonoBehaviour, ICollectable
{
    [SerializeField] LinkStats stats;

    public void Collect(Collector collector) {
        stats.maxHealth++;
        stats.currentHealth++;
        Destroy(gameObject);
    }
}

