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
        AudioManager.Instance.PlayOneShot("CogerItems");
        AudioManager.Instance.PlayOneShot("ComprarItems");
        stats.bombCount += bombAmount;
        AudioManager.Instance.PlayOneShot("MenosRupias");
        GameManager.Instance.shopVisited[2] = true;
        shopManager.DestroyObjects();
        Destroy(gameObject);
    }
}
