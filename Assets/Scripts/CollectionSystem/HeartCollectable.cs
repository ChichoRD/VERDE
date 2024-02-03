using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollectable : MonoBehaviour, ICollectable
{
    [SerializeField] LinkStats stats;

    public void Collect(Collector collector)
    {
        stats.currentHealth++;
        Destroy(gameObject);
    }
}

