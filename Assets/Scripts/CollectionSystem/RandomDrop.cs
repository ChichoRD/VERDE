using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDrop : MonoBehaviour
{
    [SerializeField] GameObject[] randomItems;
    public void Drop()
    {
        if(Random.Range(0,2) == 0)
        {
            GameObject randomItem = randomItems[Random.Range(0, randomItems.Length)];
            Instantiate(randomItem, transform.position, Quaternion.identity);
        }
    }
}
