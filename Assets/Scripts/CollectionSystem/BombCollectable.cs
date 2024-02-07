using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollectable : MonoBehaviour, ICollectable
{
    [SerializeField] LinkStats stats;
    [SerializeField] ShopManager shopManager;
    int bombAmount = 4;

    public void Collect(Collector collector)
    {
        if (stats.rupeeCount >= 20) {
            stats.rupeeCount -= 20;
            stats.bombCount += bombAmount;
            GameManager.Instance.shopVisited[2] = true;
            shopManager.DestroyObjects();
            Destroy(gameObject);
        }
    }
}
