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
            AudioManager.Instance.PlayOneShot("CogerItems");
            AudioManager.Instance.PlayOneShot("ComprarItems");
            stats.rupeeCount -= 20;
            stats.bombCount += bombAmount;
            AudioManager.Instance.PlayOneShot("MenosRupias");
            GameManager.Instance.shopVisited[2] = true;
            shopManager.DestroyObjects();
            Destroy(gameObject);
        }
    }

}
