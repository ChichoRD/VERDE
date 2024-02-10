using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwordCollectible : MonoBehaviour, ICollectable
{
    [SerializeField] UnityEvent onCollect;
    [SerializeField] UnityEvent onDestroy;
    [SerializeField] LinkStats linkStats;

    [SerializeField] ShopManager shopManager;

    public void Collect(Collector collector)
    {
        collector.GetComponent<Animator>().Play("GetItem");
        AudioManager.Instance.PlayOneShot("CogerItems");
        AudioManager.Instance.PlayOneShot("ComprarItems");
        linkStats.hasSword = true;
        transform.position = new Vector3(collector.transform.position.x, collector.transform.position.y + 1.2f, transform.position.z);
        onCollect?.Invoke();
        GameManager.Instance.shopVisited[0] = true;
        Destroy(this.gameObject, 2f);
    }

    private void OnDestroy() 
    {
        onDestroy?.Invoke();
    }

    private void Start() {
        if (GameManager.Instance.linkStats.hasSword) Destroy(this.gameObject);
    }
}
