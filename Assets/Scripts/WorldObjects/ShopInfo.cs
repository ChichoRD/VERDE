using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopInfo", menuName = "MAP-World-Inc/ShopInfo")]
public class ShopInfo : ScriptableObject
{
    [SerializeField] bool _hasPrices;
    public bool hasPrices { get { return _hasPrices; } }

    [SerializeField] string _shopText;
    public string shopText { get { return _shopText; } }

    [SerializeField] GameObject[] _shopObjects;
    public GameObject[] shopObjects { get { return _shopObjects; } }

    [SerializeField] int[] _shopPrice;
    public int[] shopPrice { get { return _shopPrice; } }

    [SerializeField] Vector3 _shopExit;
    public Vector3 shopExit { get { return _shopExit; } }
}
