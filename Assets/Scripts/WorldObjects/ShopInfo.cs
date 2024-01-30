using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInfo : ScriptableObject
{
    [SerializeField] bool _hasPrices;
    public bool hasPrices { get { return _hasPrices; } }

    [SerializeField] string _shopText;
    public string shopText { get { return _shopText; } }

    //[SerializeField] T[] _shopObjects;
    //public T[] shopObjects { get { return _shopObjects; } }
}
