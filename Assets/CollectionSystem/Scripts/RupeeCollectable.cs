using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RupeeCollectable : MonoBehaviour, ICollectable
{
    LinkStats stats;
    int rupeeAmount = 1;

    public void Collect()
    {
        stats.rupeeCount += rupeeAmount;
        Destroy(gameObject);
    }
}
