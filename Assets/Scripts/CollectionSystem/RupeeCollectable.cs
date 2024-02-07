using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RupeeCollectable : MonoBehaviour, ICollectable
{
    [SerializeField] LinkStats stats;
    int rupeeAmount = 1;

    public void Collect(Collector collector)
    {
        stats.rupeeCount += rupeeAmount;
        AudioManager.Instance.PlayOneShot("CogerRupias");
        Destroy(gameObject);
    }
}
