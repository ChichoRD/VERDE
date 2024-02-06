using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionCollectable : MonoBehaviour, ICollectable
{
    [SerializeField] LinkStats stats;
    [SerializeField] ShopManager shopManager;

    public void Collect(Collector collector) {
        stats.currentHealth = stats.maxHealth;
        GameManager.Instance.shopVisited[1] = true;
        shopManager.DestroyObjects();
        Destroy(gameObject);
    }
}
