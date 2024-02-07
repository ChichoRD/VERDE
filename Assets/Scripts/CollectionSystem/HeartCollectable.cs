using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollectable : MonoBehaviour, ICollectable
{
    [SerializeField] LinkStats stats;

    public void Collect(Collector collector)
    {
        AudioManager.Instance.PlayOneShot("CogerCoraz�n");
        if (stats.currentHealth < stats.maxHealth) {
            stats.currentHealth++;          
        }
        Destroy(gameObject);
    }
}

