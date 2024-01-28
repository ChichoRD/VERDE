using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollectable : MonoBehaviour, ICollectable
{
    [SerializeField] LinkStats stats;
    int bombAmount = 4;

    public void Collect()
    {
        stats.bombCount += bombAmount;
        Destroy(gameObject);
    }
}
