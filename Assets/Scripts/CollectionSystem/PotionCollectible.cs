using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionCollectable : MonoBehaviour, ICollectable
{
    [SerializeField] LinkStats stats;

    public void Collect(Collector collector) {
        stats.currentHealth = stats.maxHealth;
        Destroy(gameObject);
    }
}
