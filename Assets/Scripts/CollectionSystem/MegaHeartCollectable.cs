using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaHeartCollectable : MonoBehaviour, ICollectable
{
    [SerializeField] LinkStats stats;
    [SerializeField] ShopManager shopManager;

    public void Collect(Collector collector) {
        stats.maxHealth++;
        stats.currentHealth++;
        GameManager.Instance.shopVisited[1] = true;
        shopManager.DestroyObjects();
        Destroy(gameObject);
    }
}

