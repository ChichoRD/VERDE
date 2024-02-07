using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu(fileName = "LinkStats", menuName = "MAP-World-Inc/LinkStats", order = 0)]
public class LinkStats : ScriptableObject 
{
    int _currentHealth;
    public int currentHealth
    {
        get { return _currentHealth; }
        set
        {
            _currentHealth = value;
            OnHealthChange?.Invoke(_currentHealth);
        }
    }

    int _maxHealth;
    public int maxHealth => _maxHealth;
    

    int _bombCount;
    public int bombCount
    {
        get { return _bombCount; }
        set
        {
            _bombCount = value;
            OnBombChange?.Invoke(_bombCount);
        }
    }

    int _rupeeCount;
    public int rupeeCount
    {
        get { return _rupeeCount; }
        set
        {
            _rupeeCount = value;
            OnRupeeChange?.Invoke(_rupeeCount);
        }
    }

    int _keyCount;
    public int keyCount
    {
        get { return _keyCount; }
        set
        {
            _keyCount = value;
            OnKeyChange?.Invoke(_keyCount);
        }
    }

    bool _hasSword = false;
    public bool hasSword
    {
        get { return _hasSword; }
        set
        {
            _hasSword = value;
            OnTakeSword?.Invoke();
        }
    }

    public UnityEvent<int> OnHealthChange = new UnityEvent<int>();
    public UnityEvent<int> OnBombChange = new UnityEvent<int>();
    public UnityEvent<int> OnRupeeChange = new UnityEvent<int>();
    public UnityEvent<int> OnKeyChange = new UnityEvent<int>();
    public UnityEvent OnTakeSword = new UnityEvent();


    public void Reset()
    {
        bombCount = 0;
        rupeeCount = 0;
        keyCount = 0;
        hasSword = false;
        currentHealth = maxHealth;
    }
}

