using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public int shopNumber;

    [SerializeField] GameObject[] objList;

    [SerializeField] GameObject pj;

    [SerializeField] GameObject text;
    void Start()
    {
        if (GameManager.Instance.shopVisited[shopNumber]) {
            DestroyObjects();
        }
    }

    public void DestroyObjects() {
        foreach (GameObject o in objList) {
            Destroy(o);
        }
        Destroy(pj);
        Destroy(text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
