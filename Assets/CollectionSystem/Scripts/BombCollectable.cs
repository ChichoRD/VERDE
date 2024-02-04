using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollectable : MonoBehaviour
{
    LinkStats stats;
    int bombAmount = 4;

    public void Collect()
    {
        stats.bombCount += bombAmount;
        Destroy(gameObject);
    }
}
