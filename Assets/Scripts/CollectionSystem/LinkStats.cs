using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu(fileName = "LinkStats", menuName = "MAP-World-Inc/LinkStats", order = 0)]
public class LinkStats : ScriptableObject 
{
    [SerializeField] bool _hasSword;
    public bool hasSword {
        get { return _hasSword; }
        set {
            _hasSword = value;
            OnHasSwordChange.Invoke(_hasSword);
        }
    }

    [SerializeField] int _maxHealth;
    public int maxHealth
    {
        get { return _maxHealth; }
        set
        {
            _maxHealth = value;
            OnMaxHealthChange.Invoke(_maxHealth);
        }
    }

    [SerializeField] int _currentHealth;
    public int currentHealth
    {
        get { return _currentHealth; }
        set
        {
            _currentHealth = value;
            OnCurrentHealthChange.Invoke(_currentHealth);
        }
    }

    [SerializeField] int _bombCount;
    public int bombCount
    {
        get { return _bombCount; }
        set
        {
            _bombCount = value;
            OnBombChange.Invoke(_bombCount);
        }
    }

    [SerializeField] int _rupeeCount = 0;
    public int rupeeCount
    {
        get { return _rupeeCount; }
        set
        {
            _rupeeCount = value;
            OnRupeeChange.Invoke(_rupeeCount);
        }
    }

    [SerializeField] int _keyCount;
    public int keyCount
    {
        get { return _keyCount; }
        set
        {
            _keyCount = value;
            OnKeyChange.Invoke(_keyCount);
        }
    }

    public UnityEvent<bool> OnHasSwordChange = new UnityEvent<bool>();
    public UnityEvent<int> OnMaxHealthChange = new UnityEvent<int>();
    public UnityEvent<int> OnCurrentHealthChange = new UnityEvent<int>();
    public UnityEvent<int> OnBombChange = new UnityEvent<int>();
    public UnityEvent<int> OnRupeeChange = new UnityEvent<int>();
    public UnityEvent<int> OnKeyChange = new UnityEvent<int>();


    public void Reset()
    {
        hasSword = false;
        bombCount = 0;
        rupeeCount = 0;
        keyCount = 0;
    }
}

